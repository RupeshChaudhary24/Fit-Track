using System.Text.Json.Serialization;

namespace FitTrack.Models
{
    [JsonDerivedType(typeof(WeightLossGoal), "WeightLoss")]
    [JsonDerivedType(typeof(FatLossGoal), "FatLoss")]
    [JsonDerivedType(typeof(StrengthGoal), "Strength")]
    [JsonDerivedType(typeof(EnduranceGoal), "Endurance")]
    public abstract class FitnessGoal
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public decimal StartValue { get; set; }
        public decimal TargetValue { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime TargetDate { get; set; } = DateTime.Today.AddMonths(1);
        public List<ProgressEntry> ProgressEntries { get; set; } = new();

        [JsonIgnore]
        public decimal CurrentValue
        {
            get
            {
                if (ProgressEntries.Count == 0)
                    return StartValue;

                return ProgressEntries
                    .OrderBy(entry => entry.EntryDate)
                    .Last()
                    .LoggedValue;
            }
        }

        [JsonIgnore]
        public abstract string GoalType { get; }

        [JsonIgnore]
        public abstract decimal ProgressPercentage { get; }

        [JsonIgnore]
        public bool IsCompleted => ProgressPercentage >= 100;
    }
}