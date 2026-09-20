namespace FitTrack.Forms
{
    partial class LogProgressForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblEntryDate = new Label();
            dtpEntryDate = new DateTimePicker();
            lblLoggedValue = new Label();
            numLoggedValue = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numLoggedValue).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(219, 52);
            lblHeading.Margin = new Padding(6, 0, 6, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(213, 30);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Log Fitness Progress";
            // 
            // lblEntryDate
            // 
            lblEntryDate.AutoSize = true;
            lblEntryDate.Location = new Point(165, 146);
            lblEntryDate.Name = "lblEntryDate";
            lblEntryDate.Size = new Size(154, 30);
            lblEntryDate.TabIndex = 1;
            lblEntryDate.Text = "Progress Date:";
            // 
            // dtpEntryDate
            // 
            dtpEntryDate.Format = DateTimePickerFormat.Short;
            dtpEntryDate.Location = new Point(325, 146);
            dtpEntryDate.Name = "dtpEntryDate";
            dtpEntryDate.Size = new Size(180, 35);
            dtpEntryDate.TabIndex = 2;
            // 
            // lblLoggedValue
            // 
            lblLoggedValue.AutoSize = true;
            lblLoggedValue.Location = new Point(165, 197);
            lblLoggedValue.Name = "lblLoggedValue";
            lblLoggedValue.Size = new Size(152, 30);
            lblLoggedValue.TabIndex = 3;
            lblLoggedValue.Text = "Current Value:";
            // 
            // numLoggedValue
            // 
            numLoggedValue.DecimalPlaces = 2;
            numLoggedValue.Location = new Point(325, 195);
            numLoggedValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numLoggedValue.Name = "numLoggedValue";
            numLoggedValue.Size = new Size(180, 35);
            numLoggedValue.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Progress";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(369, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LogProgressForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 416);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numLoggedValue);
            Controls.Add(lblLoggedValue);
            Controls.Add(dtpEntryDate);
            Controls.Add(lblEntryDate);
            Controls.Add(lblHeading);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogProgressForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log Progress";
            ((System.ComponentModel.ISupportInitialize)numLoggedValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblEntryDate;
        private DateTimePicker dtpEntryDate;
        private Label lblLoggedValue;
        private NumericUpDown numLoggedValue;
        private Button btnSave;
        private Button btnCancel;
    }
}