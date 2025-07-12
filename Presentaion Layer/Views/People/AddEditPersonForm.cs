using Domain_Layer;
using Domain_Layer.Models.Country;
using Presentaion_Layer.Common_For_Coloring___Themes;
using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer.Views.People;

public partial class AddEditPersonForm : Form, IAddEditPersonView
{
    public event Predicate<PersonModel> PersonSavedInDB = (p) => { return false; };
    public event EventHandler<PersonModel?> DataBack = delegate { };

    Mode mode = Mode.Add;
    public BindingSource CountriesSource { set => CountryComboBox.DataSource = value; }
    public string DisplayedMemCountryList
    {
        set => CountryComboBox.DisplayMember = value;
        get => CountryComboBox.DisplayMember;
    }
    public string ValueMemCountryList
    {
        set => CountryComboBox.ValueMember = value;
        get => CountryComboBox.ValueMember;
    }
    public string FormText { set => Text = value; get => Text; }

    #region Short Names For Props
    string FirstName { get => FirstNameTextBox.Text; }
    string SecondName { get => SecondNameTextBox.Text; }
    string ThirdName { get => ThirdNameTextBox.Text; }
    string LastName { get => LastNameTextBox.Text; }


    string Phone { get => PhoneTextBox.Text; }
    string Email { get => EmailTextBox.Text; }

    bool Gender { get => Convert.ToBoolean(GenderComboBox.SelectedIndex); }
    DateOnly? DateOfBirth
    {
        get
        {
            if (DateOnly.TryParse(DateOfBirthMaskedTextBox.Text, out DateOnly dob))
                return dob;
            return null;
        }
    }
    CountryModel Country
    {
        get { return (mode==Mode.Add)?new CountryModel { Name = CountryComboBox.Text.ToString(), Id = (int)CountryComboBox.SelectedValue! }:
                PersonModel.Country; }
    }
    string NationalNo
    {
        get => NationalNoTextBox.Text;
    }
    string Address
    {
        get => AddressTextBox.Text;
    }

    #endregion 

    PersonModel? _personModel;
    public PersonModel? PersonModel
    {
        get => _personModel;
        set { _personModel = value; mode = Mode.Edit; }
    }
    public AddEditPersonForm()
    {
        InitializeComponent();
    }

    private void FillForm()
    {
        if (mode == Mode.Edit)
        {
            GenderComboBox.SelectedIndex = Convert.ToInt32(_personModel.Gender);
            CountryComboBox.SelectedValue = _personModel.Country.Id;

            CountryComboBox.Enabled = false;
            GenderComboBox.Enabled = false;
        }
        else { 
            GenderComboBox.SelectedIndex = 0;
            return; }

        FirstNameTextBox.Text = _personModel.FirstName;
        SecondNameTextBox.Text = _personModel.SecondName;
        ThirdNameTextBox.Text = _personModel.ThirdName;
        LastNameTextBox.Text = _personModel.LastName;

        PhoneTextBox.Text = _personModel.Phone;
        EmailTextBox.Text = _personModel.Email;


  

        DateOfBirthMaskedTextBox.Text = _personModel.DateOfBirth.ToString("MM/dd/yyyy");

        NationalNoTextBox.Text = _personModel.NationalNo;
        NationalNoTextBox.Enabled = false;


        AddressTextBox.Text = _personModel.Address;

        if (!string.IsNullOrWhiteSpace(_personModel.ImagePath))
        {
            PersonPictureBox.Image = Image.FromFile(_personModel.ImagePath);
        }

    }
    private  void AddEditPersonForm_Load(object sender, EventArgs e)
    {
        FillForm();
    }

    private void SetImgeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        if (ChoosePictureOpenFileDialog.ShowDialog() == DialogResult.OK)
            PersonPictureBox.Image = Image.FromFile(ChoosePictureOpenFileDialog.FileName);

    }
    private PersonModel fillPerson()
    {
       if (DateOfBirth == null)
         throw new NullReferenceException($"The {nameof(DateOfBirth)} cannot be null.");

        return new PersonModel
        {
            FirstName = FirstName,
            SecondName = SecondName,
            ThirdName = string.IsNullOrWhiteSpace(ThirdName) ? null:ThirdName ,
            LastName = LastName,
            Phone = Phone,
            Email = string.IsNullOrWhiteSpace(Email) ? null : Email,
            Gender = Gender,
            DateOfBirth =(DateOnly)DateOfBirth ,
            Country = Country,
            NationalNo = NationalNo,
            Address = Address
        };
    }
    private void refillPerson()
    {
        if (DateOfBirth == null)
            throw new NullReferenceException($"The {nameof(DateOfBirth)} cannot be null.");

       PersonModel.FirstName = FirstName;
       PersonModel.SecondName = SecondName;
       PersonModel.ThirdName = string.IsNullOrWhiteSpace(ThirdName) ? null : ThirdName;
       PersonModel.LastName = LastName;
       PersonModel.Phone = Phone;
       PersonModel.Email = string.IsNullOrWhiteSpace(Email) ? null : Email;
       PersonModel.Gender = Gender;
       PersonModel.DateOfBirth = (DateOnly)DateOfBirth;
       PersonModel.Country = Country;
       PersonModel.NationalNo = NationalNo;
       PersonModel.Address = Address;
       
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        switch(mode)
        {
            case Mode.Add: 
                _personModel = fillPerson();   
                break;
            case Mode.Edit: refillPerson(); break;
        }
       
        if (PersonSavedInDB.Invoke(_personModel))
        {
  
            DataBack(this, _personModel);
            Close();
        }
        else
        {
            DataBack(this, null);
        }

    }


    private void FirstNameTextBox_Validating(object sender, CancelEventArgs e)
    {
   //     _showError(FirstNameTextBox);
    }

    private void SecondNameTextBox_Validating(object sender, CancelEventArgs e)
    {
     //   _showError(SecondNameTextBox);

    }

    private void LastNameTextBox_Validating(object sender, CancelEventArgs e)
    {
      //  _showError(LastNameTextBox);
    }
}
