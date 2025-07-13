namespace Presentaion_Layer.Views.Users
{
    partial class AddEditUserForm
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
            components = new System.ComponentModel.Container();
            PersonInfoUserInfotabControl = new TabControl();
            personalInfo = new TabPage();
            loginInfo = new TabPage();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            UserNameTextBox = new TextBox();
            ActiveCheckBox = new CheckBox();
            ConfirmPasswordConstLabel = new Label();
            PasswordConstLabel = new Label();
            UserNameConstLabel = new Label();
            saveButton = new Button();
            closeButton = new Button();
            errorProvider = new ErrorProvider(components);
            PersonInfoUserInfotabControl.SuspendLayout();
            loginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // PersonInfoUserInfotabControl
            // 
            PersonInfoUserInfotabControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PersonInfoUserInfotabControl.Controls.Add(personalInfo);
            PersonInfoUserInfotabControl.Controls.Add(loginInfo);
            PersonInfoUserInfotabControl.Location = new Point(0, 3);
            PersonInfoUserInfotabControl.Name = "PersonInfoUserInfotabControl";
            PersonInfoUserInfotabControl.SelectedIndex = 0;
            PersonInfoUserInfotabControl.Size = new Size(869, 471);
            PersonInfoUserInfotabControl.TabIndex = 0;
            PersonInfoUserInfotabControl.Selecting += PersonInfoUserInfotabControl_Selecting;
            // 
            // personalInfo
            // 
            personalInfo.BackColor = Color.FromArgb(33, 33, 33);
            personalInfo.Location = new Point(4, 24);
            personalInfo.Name = "personalInfo";
            personalInfo.Padding = new Padding(3);
            personalInfo.Size = new Size(861, 443);
            personalInfo.TabIndex = 0;
            personalInfo.Text = "Personal Info";
            personalInfo.Click += personalInfo_Click;
            // 
            // loginInfo
            // 
            loginInfo.BackColor = Color.FromArgb(33, 33, 33);
            loginInfo.Controls.Add(maskedTextBox2);
            loginInfo.Controls.Add(maskedTextBox1);
            loginInfo.Controls.Add(UserNameTextBox);
            loginInfo.Controls.Add(ActiveCheckBox);
            loginInfo.Controls.Add(ConfirmPasswordConstLabel);
            loginInfo.Controls.Add(PasswordConstLabel);
            loginInfo.Controls.Add(UserNameConstLabel);
            loginInfo.Location = new Point(4, 24);
            loginInfo.Name = "loginInfo";
            loginInfo.Padding = new Padding(3);
            loginInfo.Size = new Size(861, 443);
            loginInfo.TabIndex = 1;
            loginInfo.Text = "Login Info";
            loginInfo.Click += loginInfo_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            maskedTextBox2.Location = new Point(173, 183);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(139, 25);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.UseSystemPasswordChar = true;
            maskedTextBox2.Validating += maskedTextBox2_Validating;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            maskedTextBox1.Location = new Point(173, 136);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(139, 25);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.UseSystemPasswordChar = true;
            maskedTextBox1.Validating += maskedTextBox1_Validating;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(173, 86);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(139, 25);
            UserNameTextBox.TabIndex = 4;
            UserNameTextBox.Validating += UserNameTextBox_Validating;
            // 
            // ActiveCheckBox
            // 
            ActiveCheckBox.AutoSize = true;
            ActiveCheckBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ActiveCheckBox.ForeColor = Color.White;
            ActiveCheckBox.Location = new Point(196, 226);
            ActiveCheckBox.Name = "ActiveCheckBox";
            ActiveCheckBox.Size = new Size(67, 23);
            ActiveCheckBox.TabIndex = 3;
            ActiveCheckBox.Text = "Active";
            ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordConstLabel
            // 
            ConfirmPasswordConstLabel.AutoSize = true;
            ConfirmPasswordConstLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmPasswordConstLabel.ForeColor = Color.White;
            ConfirmPasswordConstLabel.Location = new Point(22, 188);
            ConfirmPasswordConstLabel.Name = "ConfirmPasswordConstLabel";
            ConfirmPasswordConstLabel.Size = new Size(145, 20);
            ConfirmPasswordConstLabel.TabIndex = 2;
            ConfirmPasswordConstLabel.Text = "Confirm Password :";
            // 
            // PasswordConstLabel
            // 
            PasswordConstLabel.AutoSize = true;
            PasswordConstLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordConstLabel.ForeColor = Color.White;
            PasswordConstLabel.Location = new Point(22, 137);
            PasswordConstLabel.Name = "PasswordConstLabel";
            PasswordConstLabel.Size = new Size(84, 20);
            PasswordConstLabel.TabIndex = 1;
            PasswordConstLabel.Text = "Password :";
            // 
            // UserNameConstLabel
            // 
            UserNameConstLabel.AutoSize = true;
            UserNameConstLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameConstLabel.ForeColor = Color.White;
            UserNameConstLabel.Location = new Point(22, 86);
            UserNameConstLabel.Name = "UserNameConstLabel";
            UserNameConstLabel.Size = new Size(95, 20);
            UserNameConstLabel.TabIndex = 0;
            UserNameConstLabel.Text = "User Name :";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(60, 60, 60);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(773, 490);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(84, 30);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(60, 60, 60);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(679, 491);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(84, 30);
            closeButton.TabIndex = 6;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddEditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(869, 533);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(PersonInfoUserInfotabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEditUserForm";
            Text = "AddEditUserForm";
            Load += AddUserForm_Load;
            PersonInfoUserInfotabControl.ResumeLayout(false);
            loginInfo.ResumeLayout(false);
            loginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl PersonInfoUserInfotabControl;
        private TabPage loginInfo;
        private Button saveButton;
        private Button closeButton;
        private TextBox UserNameTextBox;
        private CheckBox ActiveCheckBox;
        private Label ConfirmPasswordConstLabel;
        private Label PasswordConstLabel;
        private Label UserNameConstLabel;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ErrorProvider errorProvider;
        private TabPage personalInfo;
    }
}