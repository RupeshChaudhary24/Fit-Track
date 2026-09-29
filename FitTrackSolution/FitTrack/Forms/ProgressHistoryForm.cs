using FitTrack.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FitTrack.Forms
{
    public partial class ProgressHistoryForm : Form
    {
        public ProgressHistoryForm()
        {
            InitializeComponent();
            dgvHistory.AutoGenerateColumns = false;
        }

        public ProgressHistoryForm(FitnessGoal goal) : this()
        {
            lblGoalName.Text = $"{goal.Name} ({goal.GoalType})";

            List<ProgressEntry> entries =
                (goal.ProgressEntries ?? new List<ProgressEntry>())
                .OrderBy(entry => entry.EntryDate)
                .Select(entry => new ProgressEntry
                {
                    EntryDate = entry.EntryDate,
                    LoggedValue = entry.LoggedValue
                })
                .ToList();

            dgvHistory.DataSource = entries;
            lblEmptyHistory.Visible = entries.Count == 0;
        }
    }
}
