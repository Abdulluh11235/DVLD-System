namespace Presentaion_Layer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SidePanel = new Panel();
            AccountSettingsBtn = new Button();
            DriversBtn = new Button();
            ApplicationBtn = new Button();
            UsersBtn = new Button();
            PeopleBtn = new Button();
            HeaderSidePanel = new Panel();
            pictureBox1 = new PictureBox();
            ConstHeaderPanelLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            drivingLicenseServices = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replaceLostOrDamagedLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            reToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageDetainedLicesnsesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem1 = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            MainPanel = new Panel();
            SidePanel.SuspendLayout();
            HeaderSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(45, 30, 47);
            SidePanel.Controls.Add(AccountSettingsBtn);
            SidePanel.Controls.Add(DriversBtn);
            SidePanel.Controls.Add(ApplicationBtn);
            SidePanel.Controls.Add(UsersBtn);
            SidePanel.Controls.Add(PeopleBtn);
            SidePanel.Controls.Add(HeaderSidePanel);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(200, 450);
            SidePanel.TabIndex = 0;
            // 
            // AccountSettingsBtn
            // 
            AccountSettingsBtn.BackColor = Color.FromArgb(45, 30, 47);
            AccountSettingsBtn.Dock = DockStyle.Top;
            AccountSettingsBtn.FlatAppearance.BorderSize = 0;
            AccountSettingsBtn.FlatStyle = FlatStyle.Flat;
            AccountSettingsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AccountSettingsBtn.ForeColor = Color.FromArgb(242, 242, 242);
            AccountSettingsBtn.Image = Properties.Resources.gear;
            AccountSettingsBtn.Location = new Point(0, 327);
            AccountSettingsBtn.Name = "AccountSettingsBtn";
            AccountSettingsBtn.Padding = new Padding(3);
            AccountSettingsBtn.Size = new Size(200, 56);
            AccountSettingsBtn.TabIndex = 5;
            AccountSettingsBtn.Text = "Account Settings";
            AccountSettingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AccountSettingsBtn.UseVisualStyleBackColor = false;
            AccountSettingsBtn.Click += AccountSettingsBtn_Click;
            // 
            // DriversBtn
            // 
            DriversBtn.BackColor = Color.FromArgb(45, 30, 47);
            DriversBtn.Dock = DockStyle.Top;
            DriversBtn.FlatAppearance.BorderSize = 0;
            DriversBtn.FlatStyle = FlatStyle.Flat;
            DriversBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DriversBtn.ForeColor = Color.FromArgb(242, 242, 242);
            DriversBtn.Image = Properties.Resources.driver;
            DriversBtn.Location = new Point(0, 271);
            DriversBtn.Name = "DriversBtn";
            DriversBtn.Padding = new Padding(3);
            DriversBtn.Size = new Size(200, 56);
            DriversBtn.TabIndex = 4;
            DriversBtn.Text = "Drivers";
            DriversBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DriversBtn.UseVisualStyleBackColor = false;
            // 
            // ApplicationBtn
            // 
            ApplicationBtn.BackColor = Color.FromArgb(45, 30, 47);
            ApplicationBtn.Dock = DockStyle.Top;
            ApplicationBtn.FlatAppearance.BorderSize = 0;
            ApplicationBtn.FlatStyle = FlatStyle.Flat;
            ApplicationBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ApplicationBtn.ForeColor = Color.FromArgb(242, 242, 242);
            ApplicationBtn.Image = Properties.Resources.applications;
            ApplicationBtn.Location = new Point(0, 215);
            ApplicationBtn.Name = "ApplicationBtn";
            ApplicationBtn.Padding = new Padding(3);
            ApplicationBtn.Size = new Size(200, 56);
            ApplicationBtn.TabIndex = 3;
            ApplicationBtn.Text = "Applications";
            ApplicationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ApplicationBtn.UseVisualStyleBackColor = false;
            ApplicationBtn.Click += ApplicationBtn_Click;
            // 
            // UsersBtn
            // 
            UsersBtn.BackColor = Color.FromArgb(45, 30, 47);
            UsersBtn.Dock = DockStyle.Top;
            UsersBtn.FlatAppearance.BorderSize = 0;
            UsersBtn.FlatStyle = FlatStyle.Flat;
            UsersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UsersBtn.ForeColor = Color.FromArgb(242, 242, 242);
            UsersBtn.Image = Properties.Resources.users_icon;
            UsersBtn.Location = new Point(0, 159);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Padding = new Padding(3);
            UsersBtn.Size = new Size(200, 56);
            UsersBtn.TabIndex = 2;
            UsersBtn.Text = "Users";
            UsersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UsersBtn.UseVisualStyleBackColor = false;
            UsersBtn.Click += UsersBtn_Click;
            // 
            // PeopleBtn
            // 
            PeopleBtn.BackColor = Color.FromArgb(45, 30, 47);
            PeopleBtn.Dock = DockStyle.Top;
            PeopleBtn.FlatAppearance.BorderSize = 0;
            PeopleBtn.FlatStyle = FlatStyle.Flat;
            PeopleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PeopleBtn.ForeColor = Color.FromArgb(242, 242, 242);
            PeopleBtn.Image = Properties.Resources.man;
            PeopleBtn.Location = new Point(0, 103);
            PeopleBtn.Name = "PeopleBtn";
            PeopleBtn.Padding = new Padding(3);
            PeopleBtn.Size = new Size(200, 56);
            PeopleBtn.TabIndex = 1;
            PeopleBtn.Text = "People";
            PeopleBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            PeopleBtn.UseVisualStyleBackColor = false;
            PeopleBtn.Click += PeopleBtn_Click;
            // 
            // HeaderSidePanel
            // 
            HeaderSidePanel.Controls.Add(pictureBox1);
            HeaderSidePanel.Controls.Add(ConstHeaderPanelLabel);
            HeaderSidePanel.Dock = DockStyle.Top;
            HeaderSidePanel.Location = new Point(0, 0);
            HeaderSidePanel.Name = "HeaderSidePanel";
            HeaderSidePanel.Size = new Size(200, 103);
            HeaderSidePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.formula_one_car;
            pictureBox1.Location = new Point(138, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ConstHeaderPanelLabel
            // 
            ConstHeaderPanelLabel.AutoSize = true;
            ConstHeaderPanelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConstHeaderPanelLabel.ForeColor = Color.FromArgb(242, 242, 242);
            ConstHeaderPanelLabel.Location = new Point(12, 32);
            ConstHeaderPanelLabel.Name = "ConstHeaderPanelLabel";
            ConstHeaderPanelLabel.Size = new Size(182, 42);
            ConstHeaderPanelLabel.TabIndex = 1;
            ConstHeaderPanelLabel.Text = "Driving Vehicle \r\nLicensing Department.";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(58, 43, 60);
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { drivingLicenseServices, manageApplicationsToolStripMenuItem, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(193, 136);
            // 
            // drivingLicenseServices
            // 
            drivingLicenseServices.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replaceLostOrDamagedLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem, reToolStripMenuItem });
            drivingLicenseServices.ForeColor = Color.White;
            drivingLicenseServices.Name = "drivingLicenseServices";
            drivingLicenseServices.Size = new Size(192, 22);
            drivingLicenseServices.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            newDrivingLicenseToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseToolStripMenuItem, internationalDrivingLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.ForeColor = Color.White;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(259, 22);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            localDrivingLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            localDrivingLicenseToolStripMenuItem.ForeColor = Color.White;
            localDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            localDrivingLicenseToolStripMenuItem.Size = new Size(234, 22);
            localDrivingLicenseToolStripMenuItem.Text = "Local Driving License";
            // 
            // internationalDrivingLicenseToolStripMenuItem
            // 
            internationalDrivingLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            internationalDrivingLicenseToolStripMenuItem.ForeColor = Color.White;
            internationalDrivingLicenseToolStripMenuItem.Name = "internationalDrivingLicenseToolStripMenuItem";
            internationalDrivingLicenseToolStripMenuItem.Size = new Size(234, 22);
            internationalDrivingLicenseToolStripMenuItem.Text = "International Driving License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            renewDrivingLicenseToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            renewDrivingLicenseToolStripMenuItem.ForeColor = Color.White;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(259, 22);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replaceLostOrDamagedLicenseToolStripMenuItem
            // 
            replaceLostOrDamagedLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            replaceLostOrDamagedLicenseToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            replaceLostOrDamagedLicenseToolStripMenuItem.ForeColor = Color.White;
            replaceLostOrDamagedLicenseToolStripMenuItem.Name = "replaceLostOrDamagedLicenseToolStripMenuItem";
            replaceLostOrDamagedLicenseToolStripMenuItem.Size = new Size(259, 22);
            replaceLostOrDamagedLicenseToolStripMenuItem.Text = "Replace Lost or Damaged License";
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            releaseDetainedLicenseToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            releaseDetainedLicenseToolStripMenuItem.ForeColor = Color.White;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(259, 22);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            // 
            // reToolStripMenuItem
            // 
            reToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            reToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            reToolStripMenuItem.ForeColor = Color.White;
            reToolStripMenuItem.Name = "reToolStripMenuItem";
            reToolStripMenuItem.Size = new Size(259, 22);
            reToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.ForeColor = Color.White;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(192, 22);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainedLicesnsesToolStripMenuItem, detainLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem1 });
            detainLicensesToolStripMenuItem.ForeColor = Color.White;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(192, 22);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicesnsesToolStripMenuItem
            // 
            manageDetainedLicesnsesToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            manageDetainedLicesnsesToolStripMenuItem.ForeColor = Color.White;
            manageDetainedLicesnsesToolStripMenuItem.Name = "manageDetainedLicesnsesToolStripMenuItem";
            manageDetainedLicesnsesToolStripMenuItem.Size = new Size(221, 22);
            manageDetainedLicesnsesToolStripMenuItem.Text = "Manage Detained Licenses";
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            detainLicenseToolStripMenuItem.ForeColor = Color.White;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(221, 22);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // releaseDetainedLicenseToolStripMenuItem1
            // 
            releaseDetainedLicenseToolStripMenuItem1.BackColor = Color.FromArgb(58, 43, 60);
            releaseDetainedLicenseToolStripMenuItem1.ForeColor = Color.White;
            releaseDetainedLicenseToolStripMenuItem1.Name = "releaseDetainedLicenseToolStripMenuItem1";
            releaseDetainedLicenseToolStripMenuItem1.Size = new Size(221, 22);
            releaseDetainedLicenseToolStripMenuItem1.Text = "Release Detained License";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.ForeColor = Color.White;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(192, 22);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.ForeColor = Color.White;
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(192, 22);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.BackColor = Color.FromArgb(58, 43, 60);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.ShowImageMargin = false;
            contextMenuStrip2.Size = new Size(148, 70);
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.BackColor = Color.FromArgb(58, 43, 60);
            currentUserInfoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUserInfoToolStripMenuItem.ForeColor = Color.White;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(147, 22);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePasswordToolStripMenuItem.ForeColor = Color.White;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(147, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signOutToolStripMenuItem.ForeColor = Color.White;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(147, 22);
            signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(33, 33, 33);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(584, 450);
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            MinimumSize = new Size(800, 473);
            Name = "MainForm";
            Text = "DVLD Management";
            Load += MainForm_Load;
            SidePanel.ResumeLayout(false);
            HeaderSidePanel.ResumeLayout(false);
            HeaderSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Panel HeaderSidePanel;
        private PictureBox pictureBox1;
        private Label ConstHeaderPanelLabel;
        private Button PeopleBtn;
        private Button UsersBtn;
        private Button ApplicationBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem drivingLicenseServices;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replaceLostOrDamagedLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ToolStripMenuItem reToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem manageDetainedLicesnsesToolStripMenuItem;
        private Button DriversBtn;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem1;
        private Button AccountSettingsBtn;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private Panel MainPanel;
    }
}
