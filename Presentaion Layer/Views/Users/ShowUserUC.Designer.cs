namespace Presentaion_Layer.Views.Users
{
    partial class ShowUserUC
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
            userInfo = new GroupBox();
            userIdLabel = new Label();
            userIdConstLabel = new Label();
            activeLabel = new Label();
            userNameLabel = new Label();
            activeConstLabel = new Label();
            userNameConstLabel = new Label();
            userDetailsLabel = new Label();
            userInfo.SuspendLayout();
            SuspendLayout();
            // 
            // userInfo
            // 
            userInfo.Controls.Add(userIdLabel);
            userInfo.Controls.Add(userIdConstLabel);
            userInfo.Controls.Add(activeLabel);
            userInfo.Controls.Add(userNameLabel);
            userInfo.Controls.Add(activeConstLabel);
            userInfo.Controls.Add(userNameConstLabel);
            userInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInfo.ForeColor = Color.White;
            userInfo.Location = new Point(176, 39);
            userInfo.Name = "userInfo";
            userInfo.Size = new Size(355, 127);
            userInfo.TabIndex = 0;
            userInfo.TabStop = false;
            userInfo.Text = "User Info";
            userInfo.Enter += userInfo_Enter;
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.BorderStyle = BorderStyle.Fixed3D;
            userIdLabel.FlatStyle = FlatStyle.Flat;
            userIdLabel.Location = new Point(71, 60);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(92, 19);
            userIdLabel.TabIndex = 5;
            userIdLabel.Text = "Lorum Ipsum";
            // 
            // userIdConstLabel
            // 
            userIdConstLabel.AutoSize = true;
            userIdConstLabel.Location = new Point(6, 60);
            userIdConstLabel.Name = "userIdConstLabel";
            userIdConstLabel.Size = new Size(59, 17);
            userIdConstLabel.TabIndex = 4;
            userIdConstLabel.Text = "User Id :";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new Point(244, 87);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(90, 17);
            activeLabel.TabIndex = 3;
            activeLabel.Text = "Lorum Ipsum";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(247, 34);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(90, 17);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Lorum Ipsum";
            // 
            // activeConstLabel
            // 
            activeConstLabel.AutoSize = true;
            activeConstLabel.Location = new Point(150, 87);
            activeConstLabel.Name = "activeConstLabel";
            activeConstLabel.Size = new Size(54, 17);
            activeConstLabel.TabIndex = 1;
            activeConstLabel.Text = "Active :";
            // 
            // userNameConstLabel
            // 
            userNameConstLabel.AutoSize = true;
            userNameConstLabel.Location = new Point(140, 34);
            userNameConstLabel.Name = "userNameConstLabel";
            userNameConstLabel.Size = new Size(83, 17);
            userNameConstLabel.TabIndex = 0;
            userNameConstLabel.Text = "User Name :";
            // 
            // userDetailsLabel
            // 
            userDetailsLabel.AutoSize = true;
            userDetailsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userDetailsLabel.ForeColor = Color.FromArgb(244, 244, 244);
            userDetailsLabel.Location = new Point(294, 11);
            userDetailsLabel.Name = "userDetailsLabel";
            userDetailsLabel.Size = new Size(116, 25);
            userDetailsLabel.TabIndex = 4;
            userDetailsLabel.Text = "User Details";
            // 
            // ShowUserUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(userDetailsLabel);
            Controls.Add(userInfo);
            Name = "ShowUserUC";
            Size = new Size(712, 174);
            Load += ShowUserUC_Load;
            userInfo.ResumeLayout(false);
            userInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox userInfo;
        private Label userNameLabel;
        private Label activeConstLabel;
        private Label userNameConstLabel;
        private Label activeLabel;
        private Label userDetailsLabel;
        private Label userIdConstLabel;
        private Label userIdLabel;
    }
}
