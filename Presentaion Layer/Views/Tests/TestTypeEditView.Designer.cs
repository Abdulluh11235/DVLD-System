namespace Presentaion_Layer.Views.Tests
{
    partial class TestTypeEditView
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
            testTypeFeesTextBox = new TextBox();
            testTypeNameTextBox = new TextBox();
            SaveButton = new Button();
            testTypeFeesConstLabel = new Label();
            testTypeNameConstLabel = new Label();
            testTypeIDLabel = new Label();
            editTestTypeConstLabel = new Label();
            testTypeIDConstLabel = new Label();
            testTypeDescriptionTextbox = new TextBox();
            testTypeDescriptionConstLabel = new Label();
            SuspendLayout();
            // 
            // testTypeFeesTextBox
            // 
            testTypeFeesTextBox.Location = new Point(275, 174);
            testTypeFeesTextBox.Name = "testTypeFeesTextBox";
            testTypeFeesTextBox.Size = new Size(113, 23);
            testTypeFeesTextBox.TabIndex = 42;
            // 
            // testTypeNameTextBox
            // 
            testTypeNameTextBox.Location = new Point(275, 124);
            testTypeNameTextBox.Name = "testTypeNameTextBox";
            testTypeNameTextBox.Size = new Size(173, 23);
            testTypeNameTextBox.TabIndex = 41;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(219, 281);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(80, 26);
            SaveButton.TabIndex = 40;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // testTypeFeesConstLabel
            // 
            testTypeFeesConstLabel.AutoSize = true;
            testTypeFeesConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testTypeFeesConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            testTypeFeesConstLabel.Location = new Point(96, 180);
            testTypeFeesConstLabel.Name = "testTypeFeesConstLabel";
            testTypeFeesConstLabel.Size = new Size(105, 17);
            testTypeFeesConstLabel.TabIndex = 39;
            testTypeFeesConstLabel.Text = "Test Type Fees :";
            // 
            // testTypeNameConstLabel
            // 
            testTypeNameConstLabel.AutoSize = true;
            testTypeNameConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testTypeNameConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            testTypeNameConstLabel.Location = new Point(96, 130);
            testTypeNameConstLabel.Name = "testTypeNameConstLabel";
            testTypeNameConstLabel.Size = new Size(114, 17);
            testTypeNameConstLabel.TabIndex = 38;
            testTypeNameConstLabel.Text = "Test Type Name :";
            // 
            // testTypeIDLabel
            // 
            testTypeIDLabel.AutoSize = true;
            testTypeIDLabel.BorderStyle = BorderStyle.Fixed3D;
            testTypeIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testTypeIDLabel.ForeColor = Color.FromArgb(244, 244, 244);
            testTypeIDLabel.Location = new Point(270, 75);
            testTypeIDLabel.Name = "testTypeIDLabel";
            testTypeIDLabel.Size = new Size(29, 22);
            testTypeIDLabel.TabIndex = 37;
            testTypeIDLabel.Text = "42";
            // 
            // editTestTypeConstLabel
            // 
            editTestTypeConstLabel.AutoSize = true;
            editTestTypeConstLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editTestTypeConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            editTestTypeConstLabel.Location = new Point(184, 20);
            editTestTypeConstLabel.Name = "editTestTypeConstLabel";
            editTestTypeConstLabel.Size = new Size(132, 25);
            editTestTypeConstLabel.TabIndex = 36;
            editTestTypeConstLabel.Text = "Edit Test Type";
            // 
            // testTypeIDConstLabel
            // 
            testTypeIDConstLabel.AutoSize = true;
            testTypeIDConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testTypeIDConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            testTypeIDConstLabel.Location = new Point(109, 80);
            testTypeIDConstLabel.Name = "testTypeIDConstLabel";
            testTypeIDConstLabel.Size = new Size(92, 17);
            testTypeIDConstLabel.TabIndex = 35;
            testTypeIDConstLabel.Text = "Test Type ID :";
            // 
            // testTypeDescriptionTextbox
            // 
            testTypeDescriptionTextbox.Location = new Point(168, 218);
            testTypeDescriptionTextbox.Multiline = true;
            testTypeDescriptionTextbox.Name = "testTypeDescriptionTextbox";
            testTypeDescriptionTextbox.Size = new Size(319, 57);
            testTypeDescriptionTextbox.TabIndex = 44;
            // 
            // testTypeDescriptionConstLabel
            // 
            testTypeDescriptionConstLabel.AutoSize = true;
            testTypeDescriptionConstLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testTypeDescriptionConstLabel.ForeColor = Color.FromArgb(244, 244, 244);
            testTypeDescriptionConstLabel.Location = new Point(13, 230);
            testTypeDescriptionConstLabel.Name = "testTypeDescriptionConstLabel";
            testTypeDescriptionConstLabel.Size = new Size(149, 17);
            testTypeDescriptionConstLabel.TabIndex = 43;
            testTypeDescriptionConstLabel.Text = "Test Type Description :";
            // 
            // TestTypeEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(523, 326);
            Controls.Add(testTypeDescriptionTextbox);
            Controls.Add(testTypeDescriptionConstLabel);
            Controls.Add(testTypeFeesTextBox);
            Controls.Add(testTypeNameTextBox);
            Controls.Add(SaveButton);
            Controls.Add(testTypeFeesConstLabel);
            Controls.Add(testTypeNameConstLabel);
            Controls.Add(testTypeIDLabel);
            Controls.Add(editTestTypeConstLabel);
            Controls.Add(testTypeIDConstLabel);
            Name = "TestTypeEditView";
            Text = "TestTypeEditView";
            Load += TestTypeEditView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox testTypeFeesTextBox;
        private TextBox testTypeNameTextBox;
        private Button SaveButton;
        private Label testTypeFeesConstLabel;
        private Label testTypeNameConstLabel;
        private Label testTypeIDLabel;
        private Label editTestTypeConstLabel;
        private Label testTypeIDConstLabel;
        private TextBox testTypeDescriptionTextbox;
        private Label testTypeDescriptionConstLabel;
    }
}