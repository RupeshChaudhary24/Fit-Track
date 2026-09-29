using FitTrack.Models;
using FitTrack.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FitTrack.Forms
{
    public partial class MainForm : Form
    {
        private List<FitnessGoal> goals = new();

        public MainForm()
        {
            InitializeComponent();

            goals = GoalStorage.LoadGoals();

            cmbStatusFilter.SelectedIndex = 0;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            IEnumerable<FitnessGoal> visibleGoals = goals;

            string filter =
                cmbStatusFilter.SelectedItem?.ToString() ?? "All";

            if (filter == "Active")
            {
                visibleGoals = goals.Where(goal => !goal.IsCompleted);
            }
            else if (filter == "Completed")
            {
                visibleGoals = goals.Where(goal => goal.IsCompleted);
            }

            dgvGoals.DataSource = null;
            dgvGoals.DataSource = visibleGoals.ToList();

            dgvGoals.ClearSelection();
            dgvGoals.CurrentCell = null;
        }

        private void cmbStatusFilter_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAddGoal_Click(object? sender, EventArgs e)
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

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearGoalFields();
        }

        private void btnDeleteGoal_Click(object? sender, EventArgs e)
        {
            if (dgvGoals.CurrentRow?.DataBoundItem
                is not FitnessGoal selectedGoal)
            {
                MessageBox.Show("Please select a goal.");
                return;
            }

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

        private void btnLogProgress_Click(object? sender, EventArgs e)
        {
            if (dgvGoals.CurrentRow?.DataBoundItem
                is not FitnessGoal selectedGoal)
            {
                MessageBox.Show("Please select a goal.");
                return;
            }

            using (LogProgressForm progressForm = new LogProgressForm())
            {
                if (progressForm.ShowDialog(this) == DialogResult.OK)
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

        private void btnViewHistory_Click(object? sender, EventArgs e)
        {
            if (dgvGoals.CurrentRow?.DataBoundItem
                is not FitnessGoal selectedGoal)
            {
                MessageBox.Show("Please select a goal.");
                return;
            }

            using (ProgressHistoryForm historyForm =
                new ProgressHistoryForm(selectedGoal))
            {
                historyForm.ShowDialog(this);
            }
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
        }

        private void lblTitle_Click(object? sender, EventArgs e)
        {
        }
    }
}