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
    public event Predicate<IPersonModel> PersonSavedInDB = (p) => { return false; };
    public event EventHandler<IPersonModel?> DataBack = delegate { };

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

    bool Gender { get => Convert.ToBoolean(GenderComboBox.SelectedValue); }
    DateTime? DateOfBirth
    {
        get
        {
            if (DateTime.TryParse(DateOfBirthMaskedTextBox.Text, out DateTime dob))
                return dob;
            return null;
        }
    }
    ICountryModel Country
    {
        get { return new CountryModel { Name = CountryComboBox.SelectedText, Id = (int)CountryComboBox.SelectedValue! }; }
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

    IPersonModel? _personModel;
    public IPersonModel? PersonModel
    {
        get => _personModel;
        set { _personModel = value; mode = Mode.Edit; }
    }
    public AddEditPersonForm()
    {
        InitializeComponent();
    }

    private void FillForm(IPersonModel? personModel)
    {
        if (personModel == null) return;

        FirstNameTextBox.Text = personModel.FirstName;
        SecondNameTextBox.Text = personModel.SecondName;
        ThirdNameTextBox.Text = personModel.ThirdName;
        LastNameTextBox.Text = personModel.LastName;

        PhoneTextBox.Text = personModel.Phone;
        EmailTextBox.Text = personModel.Email;

        GenderComboBox.SelectedValue = personModel.Gender;
        GenderComboBox.Enabled = false;

        CountryComboBox.SelectedValue = personModel.Country.Id;
        CountryComboBox.Enabled = false;

        DateOfBirthMaskedTextBox.Text = personModel.DateOfBirth.ToString("MM/dd/yyyy");

        NationalNoTextBox.Text = personModel.NationalNo;
        NationalNoTextBox.Enabled = false;


        AddressTextBox.Text = personModel.Address;

        if (!string.IsNullOrWhiteSpace(personModel.ImagePath))
        {
            PersonPictureBox.Image = Image.FromFile(personModel.ImagePath);
        }

    }
    private void AddEditPersonForm_Load(object sender, EventArgs e)
    {
        FillForm(_personModel);
        GenderComboBox.SelectedIndex = 0;
    }

    private void SetImgeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        if (ChoosePictureOpenFileDialog.ShowDialog() == DialogResult.OK)
            PersonPictureBox.Image = Image.FromFile(ChoosePictureOpenFileDialog.FileName);

    }
    private IPersonModel fillPerson()
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
            DateOfBirth = (DateTime)DateOfBirth ,
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
       PersonModel.DateOfBirth = (DateTime)DateOfBirth;
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
