using FitTrack.Models;
using FitTrack.Storage;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitTrack.Forms
{
    public partial class MainForm : Form
    {
        private List<FitnessGoal> goals;

        public MainForm()
        {
            InitializeComponent();

            goals = GoalStorage.LoadGoals();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvGoals.DataSource = null;
            dgvGoals.DataSource = goals;
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            if (cmbGoalType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a goal type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGoalName.Text))
            {
                MessageBox.Show("Please enter a goal name.");
                return;
            }

            if (numTargetValue.Value <= 0)
            {
                MessageBox.Show("Please enter a valid target value.");
                return;
            }

            FitnessGoal goal;

            switch (cmbGoalType.Text)
            {
                case "Weight Loss":
                    goal = new WeightLossGoal();
                    break;

                case "Fat Loss":
                    goal = new FatLossGoal();
                    break;

                case "Strength":
                    goal = new StrengthGoal();
                    break;

                case "Endurance":
                    goal = new EnduranceGoal();
                    break;

                default:
                    MessageBox.Show("Please select a valid goal type.");
                    return;
            }

            goal.Id = Guid.NewGuid();
            goal.Name = txtGoalName.Text.Trim();
            goal.StartValue = numStartValue.Value;
            goal.TargetValue = numTargetValue.Value;
            goal.StartDate = DateTime.Today;
            goal.TargetDate = dtpGoalTargetDate.Value.Date;

            goals.Add(goal);
            GoalStorage.SaveGoals(goals);

            RefreshGrid();
            ClearGoalFields();

            MessageBox.Show("Goal added successfully.");
        }

        private void ClearGoalFields()
        {
            cmbGoalType.SelectedIndex = -1;
            txtGoalName.Clear();
            numStartValue.Value = 0;
            numTargetValue.Value = 0;
            dtpGoalTargetDate.Value = DateTime.Today;
            cmbGoalType.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGoalFields();
        }

        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            if (dgvGoals.CurrentRow == null)
            {
                MessageBox.Show("Please select a goal.");
                return;
            }

            FitnessGoal selectedGoal =
                (FitnessGoal)dgvGoals.CurrentRow.DataBoundItem;

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this goal?",
                "Delete Goal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                goals.Remove(selectedGoal);
                GoalStorage.SaveGoals(goals);
                RefreshGrid();

                MessageBox.Show("Goal deleted successfully.");
            }
        }

        private void btnLogProgress_Click(object sender, EventArgs e)
        {
            if (dgvGoals.CurrentRow == null)
            {
                MessageBox.Show("Please select a goal.");
                return;
            }

            FitnessGoal selectedGoal =
                (FitnessGoal)dgvGoals.CurrentRow.DataBoundItem;

            using (LogProgressForm progressForm = new LogProgressForm())
            {
                if (progressForm.ShowDialog() == DialogResult.OK)
                {
                    if (selectedGoal.ProgressEntries == null)
                    {
                        selectedGoal.ProgressEntries =
                            new List<ProgressEntry>();
                    }

                    ProgressEntry entry = new ProgressEntry
                    {
                        EntryDate = progressForm.EntryDate,
                        LoggedValue = progressForm.LoggedValue
                    };

                    selectedGoal.ProgressEntries.Add(entry);

                    GoalStorage.SaveGoals(goals);
                    RefreshGrid();

                    MessageBox.Show("Progress saved successfully.");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}