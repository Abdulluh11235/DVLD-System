using Domain_Layer;
using Domain_Layer.Models.User;
using Presentaion_Layer.Common_For_Coloring___Themes;
using Presentaion_Layer.Views.People;
using System;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Presentaion_Layer.Presenters.Person;

namespace Presentaion_Layer.Views.Users
{
    public partial class AddEditUserForm : Form, IAddEditUserView
    {
        public event EventHandler<SearchByIdEventArgs>? SearchForPersonID;
        public event EventHandler<SearchByNationalNoEventArgs>? SearchForPersonNationalNo;

        public event Func<UserModel, int?>? addUserInDB;
        public event Predicate<UserModel?>? updateUserInDB;

        public event EventHandler<UserModel?>? DataBack;

        private enum FindBy { PersonId, NationalNo }

        UserModel? _userModel;
        Mode mode = Mode.Add;
        public UserModel? UserModel  // after setting in presenter must add card 
        {
            get => _userModel;
            set {
                      _userModel = value;    
                if (value is null) { clear(); mode = Mode.Add; }
                else { fillForm(); mode = Mode.Edit;}
                  }
        }

        private void fillForm()
        {

            UserNameTextBox.Text = UserModel!.UserName;
            ActiveCheckBox.Checked = UserModel!.Active;

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        void clear()
        {
            askForPersonControlsVisibility(true);
            
            SearchTextBox.Clear();
            UserNameTextBox.Clear();  
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();

            ActiveCheckBox.Checked = false;
            PersonInfoUserInfotabControl.SelectedIndex = 0;

            nextButton.Enabled = false;
            saveButton.Enabled = false;
        }     

        public PersonModel? PersonModel { get; set; }

       

        public AddEditUserForm()
        {
            InitializeComponent();

            FindByComboBox.SelectedIndex = 0;
      
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchForPersonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                MessageBox.Show("Please enter a valid search value.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PersonModel? person = null;
            try
            {
                switch ((FindBy)FindByComboBox.SelectedIndex)
                {
                    case FindBy.PersonId:
                        int personId = int.Parse(SearchTextBox.Text);
                        var idArgs = new SearchByIdEventArgs(personId);
                        SearchForPersonID?.Invoke(this, idArgs);
                        person = idArgs.Person;
                        break;

                    case FindBy.NationalNo:
                        var nationalNoArgs = new SearchByNationalNoEventArgs(SearchTextBox.Text);
                        SearchForPersonNationalNo?.Invoke(this, nationalNoArgs);
                        person = nationalNoArgs.Person;
                        break;

                    default:
                        MessageBox.Show("Invalid search type selected.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (person == null)
                {
                    MessageBox.Show("No person found with the provided information.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void askForPersonControlsVisibility(bool visible)
        {
            noPersonConstLabel.Visible = visible;
            RequirePersonPictureBox.Visible=visible;
            
            if(visible && cardControl is not null)
                cardControl.Visible=false;
        }
        Control? cardControl;
        public void AddPersonCard(IShowPersonUC card)
        {

            askForPersonControlsVisibility(false);

             cardControl = (Control)card;
            cardControl.Visible = true;

            cardControl.Dock = DockStyle.Bottom;
            PersonInfoUserInfotabControl.TabPages[0].Controls.Add(cardControl);

            nextButton.Enabled = true;
            saveButton.Enabled = true;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void personalInfo_Click(object sender, EventArgs e)
        {
            PersonInfoUserInfotabControl.SelectedIndex = 1;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            PersonInfoUserInfotabControl.SelectedIndex = 1;
        }

        private void loginInfo_Click(object sender, EventArgs e)
        {
            PersonInfoUserInfotabControl.SelectedIndex = 0;
        }

        private void PersonInfoUserInfotabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!nextButton.Enabled) e.Cancel = true;
        }




        private void UserNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int userNameLen = UserNameTextBox.Text.ToString().Length;

            if (userNameLen < 4 || userNameLen > 20)
                errorProvider.SetError(UserNameTextBox, "User Name Not Valid");
            else errorProvider.Clear();
        }

        private void maskedTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int passLen = maskedTextBox1.Text.ToString().Length;

            if (passLen < 8 || passLen > 20)
            {

                errorProvider.SetError(maskedTextBox1, "Password Must Be between 8 & 20");
            }
            else
            {
                errorProvider.Clear();
                errorPassMatch();
            }
        }

        private void errorPassMatch()
        {
            if (maskedTextBox1.Text.ToString() != maskedTextBox2.Text.ToString())
                errorProvider.SetError(maskedTextBox2, "Passowrd doesn\'t match");
            else
                errorProvider.Clear();
        }

        private void maskedTextBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorPassMatch();
        }
        private void dontAllowEmpty()
        {
            foreach (Control c in PersonInfoUserInfotabControl.TabPages[1].Controls)
            {
                if ((c is TextBox || c is MaskedTextBox) && string.IsNullOrEmpty(c.Text))
                    errorProvider.SetError(c, "Can\'t Leave it empty");
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            dontAllowEmpty();
            if (errorProvider.HasErrors)
                MessageBox.Show("Please correct the highlighted errors before saving.");
            else
            {
                Save();
                Close();
            }

        }

        private void Save()
        {
            if (addUserInDB is null) throw new ArgumentNullException(nameof(addUserInDB));
            if (updateUserInDB is null) throw new ArgumentNullException(nameof(updateUserInDB));
            if (DataBack is null) throw new ArgumentNullException(nameof(DataBack));

            switch (mode)
            {
                case Mode.Add:
                    fillUser();
                    messageUser(addUserInDB.Invoke(_userModel!) is not null);
                    DataBack.Invoke(this, _userModel);
                    break;

                case Mode.Edit:
                    reFillUser();
                    messageUser(updateUserInDB.Invoke(_userModel));
                    DataBack.Invoke(this, _userModel);
                    break;
            }
        }

        void messageUser(bool success)
        {
            if (_userModel is null) throw new ArgumentNullException(nameof(_userModel));

            switch (mode)
            {
                case Mode.Add:
                    if (success)
                    {
                        MessageBox.Show($"User With id {_userModel.UserID} Was Successfuly added");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                    break;
                case Mode.Edit:
                    if (success)
                    {
                        MessageBox.Show($"User With id {_userModel.UserID} Was Successfuly Updated");
                    }
                    else
                        MessageBox.Show($"Something Went Wrong");
                    break;

            }
        }


        private void reFillUser()
        {
            if (_userModel is null) throw new NullReferenceException();

            _userModel.UserName = UserNameTextBox.Text;
            _userModel.HashedPassword = maskedTextBox1.Text;
            _userModel.Person = PersonModel!;
            _userModel.Active = ActiveCheckBox.Checked;
        }

        private void fillUser()
        {
            _userModel = new UserModel()
            {
                UserName = UserNameTextBox.Text,
                HashedPassword = maskedTextBox1.Text,
                Person = PersonModel!,
                Active = ActiveCheckBox.Checked
            };
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming-Soon Feature");
        }
    }

}