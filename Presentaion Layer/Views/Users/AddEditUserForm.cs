using Domain_Layer;
using Domain_Layer.Models.User;
using Presentaion_Layer.Common_For_Coloring___Themes;
using Presentaion_Layer.Views.People;
using System;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Presentaion_Layer.Presenters.Person;
using System.Net.NetworkInformation;
using System.Text;

namespace Presentaion_Layer.Views.Users
{
    public partial class AddEditUserForm : Form, IAddEditUserView
    {
        public event EventHandler<SearchByIdEventArgs>? SearchForPersonID;
        public event EventHandler<SearchByNationalNoEventArgs>? SearchForPersonNationalNo;

        public event Func<UserModel, int?>? addUserInDB;
        public event Predicate<UserModel?>? updateUserInDB;

        public event EventHandler<UserModel?>? DataBack;


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
            UserNameTextBox.Clear();  
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            ActiveCheckBox.Checked = false;
    //     if(PersonModel is  null) 
      //      hasPerson = false;

            PersonInfoUserInfotabControl.SelectedIndex = 0;
        }     

        public PersonModel? PersonModel { get; set; }

       

        public AddEditUserForm()
        {
            InitializeComponent();      
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
        IFilterPersonUC ifilter;
        public void addPersonFilterCard(IFilterPersonUC filterPersonUC)
        {
            ifilter = filterPersonUC;
            Control c = (Control)filterPersonUC;
            c.Dock = DockStyle.Fill;
            personalInfo.Controls.Add(c);
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
            if (ifilter.PersonModel is null) { e.Cancel = true;
                messageNoPerson();
            }

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

        void messageNoPerson()
        {
             MessageBox.Show("Must Select A Person To Porceed.");

        }
        private bool dontAllowEmpty()
        {
            if (ifilter.PersonModel is null)
            { messageNoPerson();  return false; }
            else {
            PersonModel=ifilter.PersonModel;    
            }
               
           
            foreach (Control c in PersonInfoUserInfotabControl.TabPages[1].Controls)
            {
                if ((c is TextBox || c is MaskedTextBox) && string.IsNullOrEmpty(c.Text))
                    errorProvider.SetError(c, "Can\'t Leave it empty");
            }
            if (errorProvider.HasErrors)
            { MessageBox.Show("Please correct the highlighted errors before saving."); return false; }
            return true;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
           if(dontAllowEmpty())
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

    }

}