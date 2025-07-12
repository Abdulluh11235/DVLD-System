namespace Presentaion_Layer.Views.Applications
{
    partial class ApplicationTypeEditView
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
            applicationTypeFeesTextBox = new TextBox();
            applicationTypeNameTextBox = new TextBox();
            SaveButton = new Button();
            ApplicationTypeFeesConstLabel = new Label();
            applicationTypeNameConstLabel = new Label();
            applicationTypeIDLabel = new Label();
            editApplicationTypeConstLabel = new Label();
            applicationTypeIDConstLabel = new Label();
            SuspendLayout();
            // 
            // applicationTypeFeesTextBox
            // 
            applicationTypeFeesTextBox.Location = new Point(270, 186);
            applicationTypeFeesTextBox.Name = "applicationTypeFeesTextBox";
            applicationTypeFeesTextBox.Size = new Size(113, 23);
            applicationTypeFeesTextBox.TabIndex = 34;
            // 
            // applicationTypeNameTextBox
            // 
            applicationTypeNameTextBox.Location = new Point(270, 126);
            applicationTypeNameTextBox.Name = "applicationTypeNameTextBox";
            applicationTypeNameTextBox.Size = new Size(113, 23);
            applicationTypeNameTextBox.TabIndex = 33;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(241, 235);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 27);
            SaveButton.TabIndex = 32;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ApplicationTypeFeesConstLabel
            // 
            ApplicationTypeFeesConstLabel.AutoSize = true;
            ApplicationTypeFeesConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicationTypeFeesConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            ApplicationTypeFeesConstLabel.Location = new Point(104, 187);
            ApplicationTypeFeesConstLabel.Name = "ApplicationTypeFeesConstLabel";
            ApplicationTypeFeesConstLabel.Size = new Size(151, 17);
            ApplicationTypeFeesConstLabel.TabIndex = 31;
            ApplicationTypeFeesConstLabel.Text = "Application Type Fees :";
            // 
            // applicationTypeNameConstLabel
            // 
            applicationTypeNameConstLabel.AutoSize = true;
            applicationTypeNameConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationTypeNameConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            applicationTypeNameConstLabel.Location = new Point(104, 127);
            applicationTypeNameConstLabel.Name = "applicationTypeNameConstLabel";
            applicationTypeNameConstLabel.Size = new Size(160, 17);
            applicationTypeNameConstLabel.TabIndex = 30;
            applicationTypeNameConstLabel.Text = "Application Type Name :";
            // 
            // applicationTypeIDLabel
            // 
            applicationTypeIDLabel.AutoSize = true;
            applicationTypeIDLabel.BorderStyle = BorderStyle.Fixed3D;
            applicationTypeIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationTypeIDLabel.ForeColor = Color.FromArgb(244, 244, 244);
            applicationTypeIDLabel.Location = new Point(265, 71);
            applicationTypeIDLabel.Name = "applicationTypeIDLabel";
            applicationTypeIDLabel.Size = new Size(29, 22);
            applicationTypeIDLabel.TabIndex = 29;
            applicationTypeIDLabel.Text = "42";
            // 
            // editApplicationTypeConstLabel
            // 
            editApplicationTypeConstLabel.AutoSize = true;
            editApplicationTypeConstLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editApplicationTypeConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            editApplicationTypeConstLabel.Location = new Point(179, 11);
            editApplicationTypeConstLabel.Name = "editApplicationTypeConstLabel";
            editApplicationTypeConstLabel.Size = new Size(200, 25);
            editApplicationTypeConstLabel.TabIndex = 28;
            editApplicationTypeConstLabel.Text = "Edit Application Type";
            // 
            // applicationTypeIDConstLabel
            // 
            applicationTypeIDConstLabel.AutoSize = true;
            applicationTypeIDConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationTypeIDConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            applicationTypeIDConstLabel.Location = new Point(104, 73);
            applicationTypeIDConstLabel.Name = "applicationTypeIDConstLabel";
            applicationTypeIDConstLabel.Size = new Size(138, 17);
            applicationTypeIDConstLabel.TabIndex = 27;
            applicationTypeIDConstLabel.Text = "Application Type ID :";
            // 
            // ApplicationTypeEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(512, 288);
            Controls.Add(applicationTypeFeesTextBox);
            Controls.Add(applicationTypeNameTextBox);
            Controls.Add(SaveButton);
            Controls.Add(ApplicationTypeFeesConstLabel);
            Controls.Add(applicationTypeNameConstLabel);
            Controls.Add(applicationTypeIDLabel);
            Controls.Add(editApplicationTypeConstLabel);
            Controls.Add(applicationTypeIDConstLabel);
            Name = "ApplicationTypeEditView";
            Text = "ApplicationTypeEditView";
            Load += ApplicationTypeEditView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox applicationTypeFeesTextBox;
        private TextBox applicationTypeNameTextBox;
        private Button SaveButton;
        private Label ApplicationTypeFeesConstLabel;
        private Label applicationTypeNameConstLabel;
        private Label applicationTypeIDLabel;
        private Label editApplicationTypeConstLabel;
        private Label applicationTypeIDConstLabel;
    }
}