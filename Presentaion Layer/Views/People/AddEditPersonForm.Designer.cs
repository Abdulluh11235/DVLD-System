namespace Presentaion_Layer.Views.People
{
    partial class AddEditPersonForm
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
            HeaderLabel = new Label();
            FullNameGroupBox = new GroupBox();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            ThirdNameLabel = new Label();
            ThirdNameTextBox = new TextBox();
            SecondNameLabel = new Label();
            SecondNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            ContactInfoGroupBox = new GroupBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            PhoneLabel = new Label();
            PhoneTextBox = new TextBox();
            GenderComboBox = new ComboBox();
            GenderLabel = new Label();
            OtherGroupBox = new GroupBox();
            SetImgeLinkLabel = new LinkLabel();
            PersonPictureBox = new PictureBox();
            CountryComboBox = new ComboBox();
            CountryLabel = new Label();
            AddressTextBox = new TextBox();
            AddressLabel = new Label();
            NationalNoTextBox = new TextBox();
            NationalNoLabel = new Label();
            DateOfBirthLabel = new Label();
            DateOfBirthMaskedTextBox = new MaskedTextBox();
            Fill_FormPictureBox = new PictureBox();
            ChoosePictureOpenFileDialog = new OpenFileDialog();
            SaveButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            FullNameGroupBox.SuspendLayout();
            ContactInfoGroupBox.SuspendLayout();
            OtherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fill_FormPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = Color.FromArgb(244, 244, 244);
            HeaderLabel.Location = new Point(148, 13);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(232, 25);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Please Enter Person Info ";
            // 
            // FullNameGroupBox
            // 
            FullNameGroupBox.Controls.Add(LastNameLabel);
            FullNameGroupBox.Controls.Add(LastNameTextBox);
            FullNameGroupBox.Controls.Add(ThirdNameLabel);
            FullNameGroupBox.Controls.Add(ThirdNameTextBox);
            FullNameGroupBox.Controls.Add(SecondNameLabel);
            FullNameGroupBox.Controls.Add(SecondNameTextBox);
            FullNameGroupBox.Controls.Add(FirstNameLabel);
            FullNameGroupBox.Controls.Add(FirstNameTextBox);
            FullNameGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullNameGroupBox.ForeColor = Color.FromArgb(244, 244, 244);
            FullNameGroupBox.Location = new Point(20, 66);
            FullNameGroupBox.Name = "FullNameGroupBox";
            FullNameGroupBox.Size = new Size(442, 87);
            FullNameGroupBox.TabIndex = 2;
            FullNameGroupBox.TabStop = false;
            FullNameGroupBox.Text = "Full Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LastNameLabel.ForeColor = Color.FromArgb(244, 244, 244);
            LastNameLabel.Location = new Point(225, 57);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(65, 15);
            LastNameLabel.TabIndex = 9;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(314, 54);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(113, 23);
            LastNameTextBox.TabIndex = 8;
            LastNameTextBox.Validating += LastNameTextBox_Validating;
            // 
            // ThirdNameLabel
            // 
            ThirdNameLabel.AutoSize = true;
            ThirdNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ThirdNameLabel.ForeColor = Color.FromArgb(244, 244, 244);
            ThirdNameLabel.Location = new Point(17, 57);
            ThirdNameLabel.Name = "ThirdNameLabel";
            ThirdNameLabel.Size = new Size(72, 15);
            ThirdNameLabel.TabIndex = 7;
            ThirdNameLabel.Text = "Third Name";
            // 
            // ThirdNameTextBox
            // 
            ThirdNameTextBox.Location = new Point(90, 54);
            ThirdNameTextBox.Name = "ThirdNameTextBox";
            ThirdNameTextBox.Size = new Size(113, 23);
            ThirdNameTextBox.TabIndex = 6;
            // 
            // SecondNameLabel
            // 
            SecondNameLabel.AutoSize = true;
            SecondNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SecondNameLabel.ForeColor = Color.FromArgb(244, 244, 244);
            SecondNameLabel.Location = new Point(225, 19);
            SecondNameLabel.Name = "SecondNameLabel";
            SecondNameLabel.Size = new Size(84, 15);
            SecondNameLabel.TabIndex = 5;
            SecondNameLabel.Text = "Second Name";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Location = new Point(314, 16);
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(113, 23);
            SecondNameTextBox.TabIndex = 4;
            SecondNameTextBox.Validating += SecondNameTextBox_Validating;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirstNameLabel.ForeColor = Color.FromArgb(244, 244, 244);
            FirstNameLabel.Location = new Point(17, 19);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(67, 15);
            FirstNameLabel.TabIndex = 3;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(90, 16);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(113, 23);
            FirstNameTextBox.TabIndex = 0;
            FirstNameTextBox.Validating += FirstNameTextBox_Validating;
            // 
            // ContactInfoGroupBox
            // 
            ContactInfoGroupBox.Controls.Add(EmailLabel);
            ContactInfoGroupBox.Controls.Add(EmailTextBox);
            ContactInfoGroupBox.Controls.Add(PhoneLabel);
            ContactInfoGroupBox.Controls.Add(PhoneTextBox);
            ContactInfoGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactInfoGroupBox.ForeColor = Color.FromArgb(244, 244, 244);
            ContactInfoGroupBox.Location = new Point(20, 159);
            ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            ContactInfoGroupBox.Size = new Size(342, 58);
            ContactInfoGroupBox.TabIndex = 10;
            ContactInfoGroupBox.TabStop = false;
            ContactInfoGroupBox.Text = "Contact Info";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EmailLabel.ForeColor = Color.FromArgb(244, 244, 244);
            EmailLabel.Location = new Point(177, 24);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(223, 20);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(113, 23);
            EmailTextBox.TabIndex = 4;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PhoneLabel.ForeColor = Color.FromArgb(244, 244, 244);
            PhoneLabel.Location = new Point(7, 23);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(42, 15);
            PhoneLabel.TabIndex = 3;
            PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(58, 20);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(113, 23);
            PhoneTextBox.TabIndex = 0;
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderComboBox.Location = new Point(73, 24);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(104, 25);
            GenderComboBox.TabIndex = 11;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GenderLabel.ForeColor = Color.FromArgb(244, 244, 244);
            GenderLabel.Location = new Point(12, 29);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(49, 15);
            GenderLabel.TabIndex = 10;
            GenderLabel.Text = "Gender";
            // 
            // OtherGroupBox
            // 
            OtherGroupBox.Controls.Add(SetImgeLinkLabel);
            OtherGroupBox.Controls.Add(PersonPictureBox);
            OtherGroupBox.Controls.Add(CountryComboBox);
            OtherGroupBox.Controls.Add(CountryLabel);
            OtherGroupBox.Controls.Add(AddressTextBox);
            OtherGroupBox.Controls.Add(AddressLabel);
            OtherGroupBox.Controls.Add(NationalNoTextBox);
            OtherGroupBox.Controls.Add(NationalNoLabel);
            OtherGroupBox.Controls.Add(DateOfBirthLabel);
            OtherGroupBox.Controls.Add(DateOfBirthMaskedTextBox);
            OtherGroupBox.Controls.Add(GenderComboBox);
            OtherGroupBox.Controls.Add(GenderLabel);
            OtherGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OtherGroupBox.ForeColor = Color.FromArgb(244, 244, 244);
            OtherGroupBox.Location = new Point(20, 229);
            OtherGroupBox.Name = "OtherGroupBox";
            OtherGroupBox.Size = new Size(579, 153);
            OtherGroupBox.TabIndex = 12;
            OtherGroupBox.TabStop = false;
            OtherGroupBox.Text = "Other";
            // 
            // SetImgeLinkLabel
            // 
            SetImgeLinkLabel.AutoSize = true;
            SetImgeLinkLabel.Location = new Point(459, 123);
            SetImgeLinkLabel.Name = "SetImgeLinkLabel";
            SetImgeLinkLabel.Size = new Size(88, 15);
            SetImgeLinkLabel.TabIndex = 21;
            SetImgeLinkLabel.TabStop = true;
            SetImgeLinkLabel.Text = "Person Picture";
            SetImgeLinkLabel.LinkClicked += SetImgeLinkLabel_LinkClicked;
            // 
            // PersonPictureBox
            // 
            PersonPictureBox.BorderStyle = BorderStyle.FixedSingle;
            PersonPictureBox.Image = Properties.Resources.image__1_;
            PersonPictureBox.Location = new Point(436, 23);
            PersonPictureBox.Name = "PersonPictureBox";
            PersonPictureBox.Size = new Size(135, 91);
            PersonPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PersonPictureBox.TabIndex = 20;
            PersonPictureBox.TabStop = false;
            // 
            // CountryComboBox
            // 
            CountryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CountryComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CountryComboBox.FormattingEnabled = true;
            CountryComboBox.Location = new Point(69, 68);
            CountryComboBox.Name = "CountryComboBox";
            CountryComboBox.Size = new Size(134, 25);
            CountryComboBox.TabIndex = 19;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CountryLabel.ForeColor = Color.FromArgb(244, 244, 244);
            CountryLabel.Location = new Point(10, 73);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(51, 15);
            CountryLabel.TabIndex = 18;
            CountryLabel.Text = "Country";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(69, 111);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(355, 23);
            AddressTextBox.TabIndex = 17;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(12, 117);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(51, 15);
            AddressLabel.TabIndex = 16;
            AddressLabel.Text = "Address";
            // 
            // NationalNoTextBox
            // 
            NationalNoTextBox.Location = new Point(311, 69);
            NationalNoTextBox.Name = "NationalNoTextBox";
            NationalNoTextBox.Size = new Size(113, 23);
            NationalNoTextBox.TabIndex = 6;
            // 
            // NationalNoLabel
            // 
            NationalNoLabel.AutoSize = true;
            NationalNoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NationalNoLabel.ForeColor = Color.FromArgb(244, 244, 244);
            NationalNoLabel.Location = new Point(205, 73);
            NationalNoLabel.Name = "NationalNoLabel";
            NationalNoLabel.Size = new Size(102, 15);
            NationalNoLabel.TabIndex = 15;
            NationalNoLabel.Text = "National Number";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DateOfBirthLabel.ForeColor = Color.FromArgb(244, 244, 244);
            DateOfBirthLabel.Location = new Point(227, 29);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(82, 15);
            DateOfBirthLabel.TabIndex = 13;
            DateOfBirthLabel.Text = "Date Of Birth";
            // 
            // DateOfBirthMaskedTextBox
            // 
            DateOfBirthMaskedTextBox.Location = new Point(316, 25);
            DateOfBirthMaskedTextBox.Mask = "00/00/0000";
            DateOfBirthMaskedTextBox.Name = "DateOfBirthMaskedTextBox";
            DateOfBirthMaskedTextBox.Size = new Size(108, 23);
            DateOfBirthMaskedTextBox.TabIndex = 12;
            DateOfBirthMaskedTextBox.ValidatingType = typeof(DateTime);
            // 
            // Fill_FormPictureBox
            // 
            Fill_FormPictureBox.Image = Properties.Resources.fill_from;
            Fill_FormPictureBox.Location = new Point(386, 8);
            Fill_FormPictureBox.Name = "Fill_FormPictureBox";
            Fill_FormPictureBox.Size = new Size(33, 35);
            Fill_FormPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Fill_FormPictureBox.TabIndex = 13;
            Fill_FormPictureBox.TabStop = false;
            // 
            // ChoosePictureOpenFileDialog
            // 
            ChoosePictureOpenFileDialog.FileName = "openFileDialog1";
            ChoosePictureOpenFileDialog.Filter = "Image Files (*jpg,*.png,*jpeg)|*jpg;*.png;*jpeg";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(261, 388);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(80, 39);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddEditPersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(609, 439);
            Controls.Add(SaveButton);
            Controls.Add(Fill_FormPictureBox);
            Controls.Add(OtherGroupBox);
            Controls.Add(ContactInfoGroupBox);
            Controls.Add(FullNameGroupBox);
            Controls.Add(HeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditPersonForm";
            Text = "Add Person";
            Load += AddEditPersonForm_Load;
            FullNameGroupBox.ResumeLayout(false);
            FullNameGroupBox.PerformLayout();
            ContactInfoGroupBox.ResumeLayout(false);
            ContactInfoGroupBox.PerformLayout();
            OtherGroupBox.ResumeLayout(false);
            OtherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fill_FormPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private GroupBox FullNameGroupBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private Label ThirdNameLabel;
        private TextBox ThirdNameTextBox;
        private Label SecondNameLabel;
        private TextBox SecondNameTextBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private GroupBox ContactInfoGroupBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label PhoneLabel;
        private TextBox PhoneTextBox;
        private ComboBox GenderComboBox;
        private Label GenderLabel;
        private GroupBox OtherGroupBox;
        private Label DateOfBirthLabel;
        private MaskedTextBox DateOfBirthMaskedTextBox;
        private TextBox AddressTextBox;
        private Label AddressLabel;
        private TextBox NationalNoTextBox;
        private Label NationalNoLabel;
        private ComboBox CountryComboBox;
        private Label CountryLabel;
        private PictureBox Fill_FormPictureBox;
        private PictureBox PersonPictureBox;
        private LinkLabel SetImgeLinkLabel;
        private OpenFileDialog ChoosePictureOpenFileDialog;
        private Button SaveButton;
        private ErrorProvider errorProvider1;
    }
}