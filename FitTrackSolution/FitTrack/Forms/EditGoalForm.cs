using FitTrack.Models;
using System;
using System.Windows.Forms;

namespace FitTrack.Forms
{
    public partial class EditGoalForm : Form
    {
        private readonly FitnessGoal goal;

        public string GoalName => txtGoalName.Text.Trim();
        public decimal StartValue => numStartValue.Value;
        public decimal TargetValue => numTargetValue.Value;
        public DateTime TargetDate => dtpTargetDate.Value.Date;

        public EditGoalForm(FitnessGoal goalToEdit)
        {
            InitializeComponent();

            goal = goalToEdit;

            lblGoalTypeValue.Text = goal.GoalType;
            txtGoalName.Text = goal.Name;

            // Allow existing values to appear even if they exceed
            // the number box's current Designer maximum.
            numStartValue.Maximum =
                Math.Max(numStartValue.Maximum, goal.StartValue);
            numTargetValue.Maximum =
                Math.Max(numTargetValue.Maximum, goal.TargetValue);

            numStartValue.Value = goal.StartValue;
            numTargetValue.Value = goal.TargetValue;
            dtpTargetDate.Value = goal.TargetDate;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GoalName))
            {
                MessageBox.Show(
                    "Please enter a goal name.",
                    "Edit Goal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtGoalName.Focus();
                return;
            }

            if (StartValue <= 0 || TargetValue <= 0)
            {
                MessageBox.Show(
                    "Start and target values must be greater than zero.",
                    "Edit Goal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool isDecreaseGoal =
                goal is WeightLossGoal || goal is FatLossGoal;

            if (isDecreaseGoal && TargetValue >= StartValue)
            {
                MessageBox.Show(
                    "For weight or fat loss, the target must be lower than the start value.",
                    "Edit Goal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!isDecreaseGoal && TargetValue <= StartValue)
            {
                MessageBox.Show(
                    "For strength or endurance, the target must be higher than the start value.",
                    "Edit Goal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (TargetDate < goal.StartDate.Date)
            {
                MessageBox.Show(
                    "The target date cannot be before the goal's start date.",
                    "Edit Goal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void EditGoalForm_Load(object? sender, EventArgs e)
        {
        }

    }
}
