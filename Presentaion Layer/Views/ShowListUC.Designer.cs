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
            DataGridView = new DataGridView();
            ListNameLabel = new Label();
            AddBtn = new Button();
            SearchByLabel = new Label();
            SearchByComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.BackgroundColor = Color.FromArgb(50, 50, 50);
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(57, 100);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView.Size = new Size(534, 286);
            DataGridView.TabIndex = 0;
            // 
            // ListNameLabel
            // 
            ListNameLabel.AutoSize = true;
            ListNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListNameLabel.ForeColor = Color.FromArgb(242, 242, 242);
            ListNameLabel.Location = new Point(264, 3);
            ListNameLabel.Name = "ListNameLabel";
            ListNameLabel.Size = new Size(142, 30);
            ListNameLabel.TabIndex = 1;
            ListNameLabel.Text = "Lorem Ipsum";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(60, 60, 60);
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.Coral;
            AddBtn.Image = Properties.Resources.man_with_add_sign2;
            AddBtn.Location = new Point(528, 58);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(63, 31);
            AddBtn.TabIndex = 2;
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // SearchByLabel
            // 
            SearchByLabel.AutoSize = true;
            SearchByLabel.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchByLabel.ForeColor = Color.FromArgb(242, 242, 242);
            SearchByLabel.Location = new Point(61, 63);
            SearchByLabel.Name = "SearchByLabel";
            SearchByLabel.Size = new Size(88, 23);
            SearchByLabel.TabIndex = 3;
            SearchByLabel.Text = "Search By";
            // 
            // SearchByComboBox
            // 
            SearchByComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchByComboBox.FormattingEnabled = true;
            SearchByComboBox.Location = new Point(157, 64);
            SearchByComboBox.Name = "SearchByComboBox";
            SearchByComboBox.Size = new Size(121, 25);
            SearchByComboBox.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            SearchTextBox.Location = new Point(295, 64);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(133, 25);
            SearchTextBox.TabIndex = 5;
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
            Controls.Add(ListNameLabel);
            Controls.Add(DataGridView);
            Name = "ShowListUC";
            Size = new Size(681, 421);
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private Label ListNameLabel;
        private Button AddBtn;
        private Label SearchByLabel;
        private ComboBox SearchByComboBox;
        private TextBox SearchTextBox;
    }
}
