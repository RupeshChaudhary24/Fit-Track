namespace FitTrack.Models
{
    public class FatLossGoal : FitnessGoal
    {
        public override string GoalType => "Fat Loss";

        public override decimal ProgressPercentage
        {
            get
            {
                decimal totalChange = StartValue - TargetValue;

                if (totalChange <= 0)
                    return 0;

                decimal completedChange = StartValue - CurrentValue;
                decimal percentage = completedChange / totalChange * 100;

                return Math.Clamp(percentage, 0, 100);
            }
        }
    }
}