using System;
using System.Windows.Forms;

namespace FitTrack.Forms
{
    public partial class LogProgressForm : Form
    {
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

        public LogProgressForm()
        {
            InitializeComponent();
            dtpEntryDate.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numLoggedValue.Value <= 0)
            {
                MessageBox.Show(
                    "Please enter a progress value.",
                    "Missing Value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}