using Domain_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer.Views.People;

public partial class ShowPersonUC : UserControl, IShowPersonUC
{
    public event EventHandler showEdit = delegate { };

    public IPersonModel PersonModel { set; get; }

    public ShowPersonUC()
    {
        InitializeComponent();
    }
    void assign_labels()
    {
        PersonIDLabel.Text = PersonModel.PersonID.ToString();

        NameLabel.Text = PersonModel.FirstName + " " +
            PersonModel.SecondName + " " + PersonModel.ThirdName + " " +
            PersonModel.LastName;

        NationalNoLabel.Text = PersonModel.NationalNo;
        GenderLabel.Text = (PersonModel.Gender) ? "Male" : "Female";
        EmailLabel.Text = PersonModel.Email;
        AddressLabel.Text = PersonModel.Address;
        DateOfBirthLabel.Text = PersonModel.DateOfBirth.ToString("MM/dd/yyyy");
        PhoneLabel.Text = PersonModel.Phone;
        CountryLabel.Text = PersonModel.Country.Name;
        //  PersonPictureBox.Image = Image.FromFile( PersonModel.ImagePath);

    }
    private void ShowPersonUC_Load(object sender, EventArgs e)
    {
        assign_labels();
    }
    private void editPersonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        showEdit.Invoke(this, e);
    }
}
