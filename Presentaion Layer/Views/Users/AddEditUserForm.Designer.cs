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
            FilterGroupBox = new GroupBox();
            FindByConstLabel = new Label();
            FindByComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            AddPersonButton = new Button();
            SearchForPersonButton = new Button();
            noPersonConstLabel = new Label();
            RequirePersonPictureBox = new PictureBox();
            nextButton = new Button();
            personalInfo = new TabPage();
            PersonInfoUserInfotabControl.SuspendLayout();
            loginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequirePersonPictureBox).BeginInit();
            personalInfo.SuspendLayout();
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
            // FilterGroupBox
            // 
            FilterGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FilterGroupBox.Controls.Add(SearchForPersonButton);
            FilterGroupBox.Controls.Add(AddPersonButton);
            FilterGroupBox.Controls.Add(SearchTextBox);
            FilterGroupBox.Controls.Add(FindByComboBox);
            FilterGroupBox.Controls.Add(FindByConstLabel);
            FilterGroupBox.FlatStyle = FlatStyle.Popup;
            FilterGroupBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterGroupBox.ForeColor = Color.White;
            FilterGroupBox.ImeMode = ImeMode.NoControl;
            FilterGroupBox.Location = new Point(58, 2);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(674, 75);
            FilterGroupBox.TabIndex = 0;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter";
            // 
            // FindByConstLabel
            // 
            FindByConstLabel.AutoSize = true;
            FindByConstLabel.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            FindByConstLabel.Location = new Point(26, 35);
            FindByConstLabel.Name = "FindByConstLabel";
            FindByConstLabel.Size = new Size(62, 17);
            FindByConstLabel.TabIndex = 0;
            FindByConstLabel.Text = "Find By :";
            // 
            // FindByComboBox
            // 
            FindByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FindByComboBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            FindByComboBox.FormattingEnabled = true;
            FindByComboBox.Items.AddRange(new object[] { "Person Id", "National No." });
            FindByComboBox.Location = new Point(115, 31);
            FindByComboBox.Name = "FindByComboBox";
            FindByComboBox.Size = new Size(131, 25);
            FindByComboBox.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            SearchTextBox.Location = new Point(275, 31);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(150, 24);
            SearchTextBox.TabIndex = 2;
            // 
            // AddPersonButton
            // 
            AddPersonButton.BackColor = Color.FromArgb(60, 60, 60);
            AddPersonButton.FlatAppearance.BorderSize = 0;
            AddPersonButton.FlatStyle = FlatStyle.Flat;
            AddPersonButton.Image = Properties.Resources.man_with_add_sign;
            AddPersonButton.Location = new Point(522, 28);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(54, 30);
            AddPersonButton.TabIndex = 1;
            AddPersonButton.UseVisualStyleBackColor = false;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // SearchForPersonButton
            // 
            SearchForPersonButton.BackColor = Color.FromArgb(60, 60, 60);
            SearchForPersonButton.FlatAppearance.BorderSize = 0;
            SearchForPersonButton.FlatStyle = FlatStyle.Flat;
            SearchForPersonButton.Image = Properties.Resources.man_with_search_sign1;
            SearchForPersonButton.Location = new Point(459, 28);
            SearchForPersonButton.Name = "SearchForPersonButton";
            SearchForPersonButton.Size = new Size(54, 30);
            SearchForPersonButton.TabIndex = 3;
            SearchForPersonButton.UseVisualStyleBackColor = false;
            SearchForPersonButton.Click += SearchForPersonButton_Click;
            // 
            // noPersonConstLabel
            // 
            noPersonConstLabel.AutoSize = true;
            noPersonConstLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noPersonConstLabel.ForeColor = Color.White;
            noPersonConstLabel.Location = new Point(189, 122);
            noPersonConstLabel.Name = "noPersonConstLabel";
            noPersonConstLabel.Size = new Size(326, 60);
            noPersonConstLabel.TabIndex = 1;
            noPersonConstLabel.Text = "You must select or add a person\r\n before adding a user.";
            // 
            // RequirePersonPictureBox
            // 
            RequirePersonPictureBox.Image = Properties.Resources.asking_for_a_person;
            RequirePersonPictureBox.Location = new Point(264, 194);
            RequirePersonPictureBox.Name = "RequirePersonPictureBox";
            RequirePersonPictureBox.Size = new Size(186, 135);
            RequirePersonPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            RequirePersonPictureBox.TabIndex = 2;
            RequirePersonPictureBox.TabStop = false;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(60, 60, 60);
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(738, 388);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(84, 30);
            nextButton.TabIndex = 7;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // personalInfo
            // 
            personalInfo.BackColor = Color.FromArgb(33, 33, 33);
            personalInfo.Controls.Add(nextButton);
            personalInfo.Controls.Add(RequirePersonPictureBox);
            personalInfo.Controls.Add(noPersonConstLabel);
            personalInfo.Controls.Add(FilterGroupBox);
            personalInfo.Location = new Point(4, 24);
            personalInfo.Name = "personalInfo";
            personalInfo.Padding = new Padding(3);
            personalInfo.Size = new Size(861, 443);
            personalInfo.TabIndex = 0;
            personalInfo.Text = "Personal Info";
            personalInfo.Click += personalInfo_Click;
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
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RequirePersonPictureBox).EndInit();
            personalInfo.ResumeLayout(false);
            personalInfo.PerformLayout();
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
        private Button nextButton;
        private PictureBox RequirePersonPictureBox;
        private Label noPersonConstLabel;
        private GroupBox FilterGroupBox;
        private Button SearchForPersonButton;
        private Button AddPersonButton;
        private TextBox SearchTextBox;
        private ComboBox FindByComboBox;
        private Label FindByConstLabel;
    }
}