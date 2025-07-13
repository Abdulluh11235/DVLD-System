namespace Presentaion_Layer.Presenters.Person
{
    partial class FilterPersonUC
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
            RequirePersonPictureBox = new PictureBox();
            noPersonConstLabel = new Label();
            FilterGroupBox = new GroupBox();
            SearchForPersonButton = new Button();
            AddPersonButton = new Button();
            SearchTextBox = new TextBox();
            FindByComboBox = new ComboBox();
            FindByConstLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)RequirePersonPictureBox).BeginInit();
            FilterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RequirePersonPictureBox
            // 
            RequirePersonPictureBox.Image = Properties.Resources.asking_for_a_person;
            RequirePersonPictureBox.Location = new Point(326, 181);
            RequirePersonPictureBox.Name = "RequirePersonPictureBox";
            RequirePersonPictureBox.Size = new Size(186, 135);
            RequirePersonPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            RequirePersonPictureBox.TabIndex = 10;
            RequirePersonPictureBox.TabStop = false;
            // 
            // noPersonConstLabel
            // 
            noPersonConstLabel.AutoSize = true;
            noPersonConstLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noPersonConstLabel.ForeColor = Color.White;
            noPersonConstLabel.Location = new Point(206, 96);
            noPersonConstLabel.Name = "noPersonConstLabel";
            noPersonConstLabel.Size = new Size(326, 60);
            noPersonConstLabel.TabIndex = 9;
            noPersonConstLabel.Text = "You must select or add a person\r\n before adding a user.";
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
            FilterGroupBox.Location = new Point(87, 5);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(672, 75);
            FilterGroupBox.TabIndex = 8;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter";
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
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            SearchTextBox.Location = new Point(275, 31);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(150, 24);
            SearchTextBox.TabIndex = 2;
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
            // FilterPersonUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(RequirePersonPictureBox);
            Controls.Add(noPersonConstLabel);
            Controls.Add(FilterGroupBox);
            Name = "FilterPersonUC";
            Size = new Size(851, 433);
            Load += FilterPersonUC_Load;
            ((System.ComponentModel.ISupportInitialize)RequirePersonPictureBox).EndInit();
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
