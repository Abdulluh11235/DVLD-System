namespace Presentaion_Layer
{
    partial class SignInForm
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
            UserPictureBox = new PictureBox();
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            SignInButton = new Button();
            RememberMeCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UserPictureBox
            // 
            UserPictureBox.Image = Properties.Resources.basic_user_icon;
            UserPictureBox.Location = new Point(231, 51);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(82, 74);
            UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserPictureBox.TabIndex = 0;
            UserPictureBox.TabStop = false;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.ForeColor = Color.FromArgb(242, 242, 242);
            UserNameLabel.Location = new Point(147, 157);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(98, 21);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "User Name ";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UserNameTextBox.Location = new Point(261, 156);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(120, 23);
            UserNameTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.FromArgb(242, 242, 242);
            PasswordLabel.Location = new Point(147, 209);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(82, 21);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PasswordMaskedTextBox.ForeColor = Color.FromArgb(35, 35, 35);
            PasswordMaskedTextBox.Location = new Point(263, 208);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(120, 23);
            PasswordMaskedTextBox.TabIndex = 4;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // SignInButton
            // 
            SignInButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SignInButton.ForeColor = Color.FromArgb(35, 35, 35);
            SignInButton.Location = new Point(210, 261);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(84, 39);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // RememberMeCheckBox
            // 
            RememberMeCheckBox.AutoSize = true;
            RememberMeCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RememberMeCheckBox.ForeColor = Color.FromArgb(242, 242, 242);
            RememberMeCheckBox.Location = new Point(212, 306);
            RememberMeCheckBox.Name = "RememberMeCheckBox";
            RememberMeCheckBox.Size = new Size(113, 19);
            RememberMeCheckBox.TabIndex = 6;
            RememberMeCheckBox.Text = "Remember Me ";
            RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(534, 363);
            Controls.Add(RememberMeCheckBox);
            Controls.Add(SignInButton);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(UserNameLabel);
            Controls.Add(UserPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox UserPictureBox;
        private Label UserNameLabel;
        private TextBox UserNameTextBox;
        private Label PasswordLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Button SignInButton;
        private CheckBox RememberMeCheckBox;
    }
}