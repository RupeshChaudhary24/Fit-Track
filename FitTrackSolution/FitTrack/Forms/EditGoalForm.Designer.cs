namespace FitTrack.Forms
{
    partial class EditGoalForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGoalForm));
            lblTitle = new Label();
            lblGoalTypeText = new Label();
            lblGoalTypeValue = new Label();
            lblGoalName = new Label();
            txtGoalName = new TextBox();
            lblStartValue = new Label();
            numStartValue = new NumericUpDown();
            lblTargetValue = new Label();
            numTargetValue = new NumericUpDown();
            lblTargetDate = new Label();
            dtpTargetDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numStartValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTargetValue).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // lblGoalTypeText
            // 
            resources.ApplyResources(lblGoalTypeText, "lblGoalTypeText");
            lblGoalTypeText.Name = "lblGoalTypeText";
            // 
            // lblGoalTypeValue
            // 
            resources.ApplyResources(lblGoalTypeValue, "lblGoalTypeValue");
            lblGoalTypeValue.Name = "lblGoalTypeValue";
            // 
            // lblGoalName
            // 
            resources.ApplyResources(lblGoalName, "lblGoalName");
            lblGoalName.Name = "lblGoalName";
            // 
            // txtGoalName
            // 
            resources.ApplyResources(txtGoalName, "txtGoalName");
            txtGoalName.Name = "txtGoalName";
            // 
            // lblStartValue
            // 
            resources.ApplyResources(lblStartValue, "lblStartValue");
            lblStartValue.Name = "lblStartValue";
            // 
            // numStartValue
            // 
            numStartValue.DecimalPlaces = 2;
            resources.ApplyResources(numStartValue, "numStartValue");
            numStartValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numStartValue.Name = "numStartValue";
            // 
            // lblTargetValue
            // 
            resources.ApplyResources(lblTargetValue, "lblTargetValue");
            lblTargetValue.Name = "lblTargetValue";
            // 
            // numTargetValue
            // 
            numTargetValue.DecimalPlaces = 2;
            resources.ApplyResources(numTargetValue, "numTargetValue");
            numTargetValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numTargetValue.Name = "numTargetValue";
            // 
            // lblTargetDate
            // 
            resources.ApplyResources(lblTargetDate, "lblTargetDate");
            lblTargetDate.Name = "lblTargetDate";
            // 
            // dtpTargetDate
            // 
            resources.ApplyResources(dtpTargetDate, "dtpTargetDate");
            dtpTargetDate.Name = "dtpTargetDate";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditGoalForm
            // 
            AcceptButton = btnSave;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpTargetDate);
            Controls.Add(lblTargetDate);
            Controls.Add(numTargetValue);
            Controls.Add(lblTargetValue);
            Controls.Add(numStartValue);
            Controls.Add(lblStartValue);
            Controls.Add(txtGoalName);
            Controls.Add(lblGoalName);
            Controls.Add(lblGoalTypeValue);
            Controls.Add(lblGoalTypeText);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditGoalForm";
            Load += EditGoalForm_Load;
            ((System.ComponentModel.ISupportInitialize)numStartValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTargetValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblGoalTypeText;
        private Label lblGoalTypeValue;
        private Label lblGoalName;
        private TextBox txtGoalName;
        private Label lblStartValue;
        private NumericUpDown numStartValue;
        private Label lblTargetValue;
        private NumericUpDown numTargetValue;
        private Label lblTargetDate;
        private DateTimePicker dtpTargetDate;
        private Button btnSave;
        private Button btnCancel;
    }
}
