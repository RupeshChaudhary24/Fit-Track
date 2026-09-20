namespace FitTrack.Models
{
    public class ProgressEntry
    {
        public DateTime EntryDate { get; set; } = DateTime.Today;
        public decimal LoggedValue { get; set; }
    }
}
