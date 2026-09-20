namespace FitTrack.Models
{
    public class StrengthGoal : FitnessGoal
    {
        public override string GoalType => "Strength";

        public override decimal ProgressPercentage
        {
            get
            {
                decimal totalChange = TargetValue - StartValue;

                if (totalChange <= 0)
                    return 0;

                decimal completedChange = CurrentValue - StartValue;
                decimal percentage = completedChange / totalChange * 100;

                return Math.Clamp(percentage, 0, 100);
            }
        }
    }
}
