using System;
using System.Windows.Forms;

namespace FitTrack.Forms
{
    public partial class LogProgressForm : Form
    {
        private readonly DateTime goalStartDate;

        public DateTime EntryDate
        {
            get
            {
                return dtpEntryDate.Value.Date;
            }
        }

        public decimal LoggedValue
        {
            get
            {
                return numLoggedValue.Value;
            }
        }

        public LogProgressForm(DateTime goalStartDate)
        {
            InitializeComponent();

            this.goalStartDate = goalStartDate.Date;
            dtpEntryDate.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numLoggedValue.Value <= 0)
            {
                MessageBox.Show(
                    "Please enter a progress value greater than zero.",
                    "Invalid Value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                numLoggedValue.Focus();
                return;
            }

            if (EntryDate < goalStartDate)
            {
                MessageBox.Show(
                    "The progress date cannot be before the goal's start date.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpEntryDate.Focus();
                return;
            }

            if (EntryDate > DateTime.Today)
            {
                MessageBox.Show(
                    "The progress date cannot be in the future.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpEntryDate.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}