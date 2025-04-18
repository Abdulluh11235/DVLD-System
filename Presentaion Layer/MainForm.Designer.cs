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
            SidePanel = new Panel();
            MainPanel = new Panel();
            HeaderSidePanel = new Panel();
            pictureBox1 = new PictureBox();
            SidePanel.SuspendLayout();
            HeaderSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(45, 30, 47);
            SidePanel.Controls.Add(HeaderSidePanel);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(200, 450);
            SidePanel.TabIndex = 0;
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
            // HeaderSidePanel
            // 
            HeaderSidePanel.Controls.Add(pictureBox1);
            HeaderSidePanel.Dock = DockStyle.Top;
            HeaderSidePanel.Location = new Point(0, 0);
            HeaderSidePanel.Name = "HeaderSidePanel";
            HeaderSidePanel.Size = new Size(200, 103);
            HeaderSidePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.formula_one_car;
            pictureBox1.Location = new Point(136, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 58);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Panel MainPanel;
        private Panel HeaderSidePanel;
        private PictureBox pictureBox1;
    }
}
