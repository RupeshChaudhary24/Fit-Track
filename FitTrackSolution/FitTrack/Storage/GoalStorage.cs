using System.Text.Json;
using FitTrack.Models;

namespace FitTrack.Storage
{
    public static class GoalStorage
    {
        private static readonly string FilePath =
            Path.Combine(AppContext.BaseDirectory, "goals.json");

        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true
        };

        public static List<FitnessGoal> LoadGoals()
        {
            if (!File.Exists(FilePath))
                return new List<FitnessGoal>();

            try
            {
                string json = File.ReadAllText(FilePath);

                return JsonSerializer.Deserialize<List<FitnessGoal>>(
                    json, Options) ?? new List<FitnessGoal>();
            }
            catch
            {
                return new List<FitnessGoal>();
            }
        }

        public static void SaveGoals(List<FitnessGoal> goals)
        {
            string json = JsonSerializer.Serialize(goals, Options);
            File.WriteAllText(FilePath, json);
        }
    }
}
