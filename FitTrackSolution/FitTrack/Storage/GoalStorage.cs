using System.Text.Json;
using System.Text.Json.Nodes;
using FitTrack.Models;

namespace FitTrack.Storage
{
    public static class GoalStorage
    {
        private static readonly string FilePath =
            Path.Combine(AppContext.BaseDirectory, "goals.json");

        private static readonly string BackupPath = FilePath + ".bak";

        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true
        };

        private static int nextId = 1;
        private static bool loadedExistingFile;

        public sealed class GoalFile
        {
            public int NextId { get; set; } = 1;
            public List<FitnessGoal> Goals { get; set; } = new();
        }

        public static int GetNextId()
        {
            int id = nextId;
            nextId = checked(nextId + 1);
            return id;
        }

        public static void ResequenceIds(List<FitnessGoal> goals)
        {
            if (goals == null || goals.Any(goal => goal == null))
                throw new InvalidDataException("The goal list is invalid.");

            for (int i = 0; i < goals.Count; i++)
                goals[i].Id = checked(i + 1);

            nextId = checked(goals.Count + 1);
        }

        public static List<FitnessGoal> LoadGoals()
        {
            if (!File.Exists(FilePath))
            {
                if (File.Exists(BackupPath) ||
                    File.Exists(FilePath + ".guid-backup.json") ||
                    File.Exists(FilePath + ".tmp"))
                {
                    throw new InvalidDataException(
                        "goals.json is missing, but a saved copy exists. Restore the file before using FitTrack.");
                }

                loadedExistingFile = false;
                nextId = 1;
                return new List<FitnessGoal>();
            }

            loadedExistingFile = true;
            string json = File.ReadAllText(FilePath);

            using JsonDocument document = JsonDocument.Parse(json);

            if (document.RootElement.ValueKind == JsonValueKind.Array)
                return ConvertOldFile(json);

            if (document.RootElement.ValueKind != JsonValueKind.Object ||
                !document.RootElement.TryGetProperty("Goals", out _) ||
                !document.RootElement.TryGetProperty("NextId", out _))
            {
                throw new InvalidDataException(
                    "The saved goals file has an unexpected format.");
            }

            GoalFile data = JsonSerializer.Deserialize<GoalFile>(json, Options)
                ?? throw new InvalidDataException(
                    "The saved goals file could not be read.");

            ValidateGoals(data.Goals);

            if (data.NextId < 1)
                throw new InvalidDataException("The next goal ID is invalid.");

            int[] previousIds = data.Goals
                .Select(goal => goal.Id)
                .ToArray();

            int previousNextId = data.NextId;

            ResequenceIds(data.Goals);

            bool idsChanged = data.Goals
                .Where((goal, index) => goal.Id != previousIds[index])
                .Any();

            if (idsChanged || previousNextId != nextId)
                SaveGoals(data.Goals);

            return data.Goals;
        }

        private static List<FitnessGoal> ConvertOldFile(string json)
        {
            JsonArray oldGoals = JsonNode.Parse(json) as JsonArray
                ?? throw new InvalidDataException(
                    "The old goals file could not be read.");

            for (int i = 0; i < oldGoals.Count; i++)
            {
                JsonObject goal = oldGoals[i] as JsonObject
                    ?? throw new InvalidDataException(
                        "The old file contains an invalid goal.");

                JsonNode oldId = goal["Id"]
                    ?? throw new InvalidDataException(
                        "A saved goal has no ID.");

                if (!Guid.TryParse(oldId.GetValue<string>(), out _))
                    throw new InvalidDataException(
                        "A saved goal has an invalid old ID.");

                goal["Id"] = checked(i + 1);
            }

            List<FitnessGoal> goals =
                JsonSerializer.Deserialize<List<FitnessGoal>>(
                    oldGoals.ToJsonString(), Options)
                ?? throw new InvalidDataException(
                    "The old goals could not be converted.");

            ValidateGoals(goals);
            ResequenceIds(goals);

            string backupPath = FilePath + ".guid-backup.json";

            if (!File.Exists(backupPath))
                File.Copy(FilePath, backupPath);

            SaveGoals(goals);
            return goals;
        }

        public static void SaveGoals(List<FitnessGoal> goals)
        {
            if (loadedExistingFile && !File.Exists(FilePath))
            {
                throw new IOException(
                    "goals.json has disappeared. Saving was stopped to protect the existing goals.");
            }

            ValidateGoals(goals);

            int afterHighestId = goals.Count == 0
                ? 1
                : checked(goals.Max(goal => goal.Id) + 1);

            nextId = Math.Max(nextId, afterHighestId);

            GoalFile data = new GoalFile
            {
                NextId = nextId,
                Goals = goals
            };

            string json = JsonSerializer.Serialize(data, Options);
            string temporaryPath = FilePath + ".tmp";

            File.WriteAllText(temporaryPath, json);

            if (File.Exists(FilePath))
                File.Copy(FilePath, BackupPath, true);

            File.Move(temporaryPath, FilePath, true);
            loadedExistingFile = true;
        }

        private static void ValidateGoals(List<FitnessGoal>? goals)
        {
            if (goals == null)
                throw new InvalidDataException("The goal list is missing.");

            HashSet<int> usedIds = new();

            foreach (FitnessGoal goal in goals)
            {
                if (goal == null || goal.Id < 1)
                    throw new InvalidDataException(
                        "A saved goal has an invalid ID.");

                if (!usedIds.Add(goal.Id))
                    throw new InvalidDataException(
                        "The saved file contains duplicate goal IDs.");
            }
        }
    }
}