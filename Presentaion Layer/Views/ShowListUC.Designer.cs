namespace Presentaion_Layer
{
    partial class ShowListUC
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            HeaderLabel = new Label();
            AddBtn = new Button();
            SearchByLabel = new Label();
            SearchByComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AllowUserToResizeColumns = false;
            DataGridView.AllowUserToResizeRows = false;
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 242, 242);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridView.ContextMenuStrip = contextMenuStrip1;
            DataGridView.GridColor = Color.Silver;
            DataGridView.Location = new Point(72, 100);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView.RowHeadersVisible = false;
            DataGridView.Size = new Size(534, 286);
            DataGridView.TabIndex = 0;
            DataGridView.CellFormatting += DataGridView_CellFormatting;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(50, 50, 50);
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, showDetailsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(147, 70);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(146, 22);
            editToolStripMenuItem.Text = " Edit ";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.cross;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(146, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.eye;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(146, 22);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.Top;
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = Color.FromArgb(242, 242, 242);
            HeaderLabel.Location = new Point(280, 14);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(142, 30);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Lorem Ipsum";
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(60, 60, 60);
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.Coral;
            AddBtn.Image = Properties.Resources.user_with_add_sign__3_;
            AddBtn.Location = new Point(543, 58);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(63, 31);
            AddBtn.TabIndex = 2;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // SearchByLabel
            // 
            SearchByLabel.AutoSize = true;
            SearchByLabel.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchByLabel.ForeColor = Color.FromArgb(242, 242, 242);
            SearchByLabel.Location = new Point(76, 63);
            SearchByLabel.Name = "SearchByLabel";
            SearchByLabel.Size = new Size(88, 23);
            SearchByLabel.TabIndex = 3;
            SearchByLabel.Text = "Search By";
            // 
            // SearchByComboBox
            // 
            SearchByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchByComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchByComboBox.FormattingEnabled = true;
            SearchByComboBox.Location = new Point(172, 64);
            SearchByComboBox.Name = "SearchByComboBox";
            SearchByComboBox.Size = new Size(121, 25);
            SearchByComboBox.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            SearchTextBox.Location = new Point(301, 64);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(121, 25);
            SearchTextBox.TabIndex = 5;
            SearchTextBox.KeyUp += SearchTextBox_KeyUp;
            // 
            // ShowListUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchByComboBox);
            Controls.Add(SearchByLabel);
            Controls.Add(AddBtn);
            Controls.Add(HeaderLabel);
            Controls.Add(DataGridView);
            DoubleBuffered = true;
            Name = "ShowListUC";
            Size = new Size(681, 421);
            Load += ShowListUC_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private Label HeaderLabel;
        private Button AddBtn;
        private Label SearchByLabel;
        private ComboBox SearchByComboBox;
        private TextBox SearchTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}
