﻿namespace Presentaion_Layer
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
            SidePanel = new Panel();
            PeopleBtn = new Button();
            HeaderSidePanel = new Panel();
            pictureBox1 = new PictureBox();
            ConstHeaderPanelLabel = new Label();
            MainPanel = new Panel();
            SidePanel.SuspendLayout();
            HeaderSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(45, 30, 47);
            SidePanel.Controls.Add(PeopleBtn);
            SidePanel.Controls.Add(HeaderSidePanel);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(200, 450);
            SidePanel.TabIndex = 0;
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
            PeopleBtn.Size = new Size(200, 56);
            PeopleBtn.TabIndex = 1;
            PeopleBtn.Text = "People";
            PeopleBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            PeopleBtn.UseVisualStyleBackColor = false;
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
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(33, 33, 33);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(600, 450);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Name = "MainForm";
            Text = "Form1";
            SidePanel.ResumeLayout(false);
            HeaderSidePanel.ResumeLayout(false);
            HeaderSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Panel MainPanel;
        private Panel HeaderSidePanel;
        private PictureBox pictureBox1;
        private Label ConstHeaderPanelLabel;
        private Button PeopleBtn;
    }
}
