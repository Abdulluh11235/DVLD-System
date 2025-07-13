using Domain_Layer;
using Presentaion_Layer.Views.People;
using Presentaion_Layer.Views.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer.Presenters.Person
{
    public partial class FilterPersonUC : UserControl, IFilterPersonUC
    {
        PersonModel _personmodel;
        public PersonModel? PersonModel
        {
            get => _personmodel;
            set
            {
                if (value is not null) { _personmodel = value; }
                else {   askForPersonControlsVisibility(true); }

                SearchTextBox.Clear();
            }
        }


        public event EventHandler<SearchByIdEventArgs>? SearchForPersonID;
        public event EventHandler<SearchByNationalNoEventArgs>? SearchForPersonNationalNo;
        private enum FindBy { PersonId, NationalNo }


        public FilterPersonUC()
        {
            InitializeComponent();
            FindByComboBox.SelectedIndex = 0;
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
              _personmodel = person;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Control? cardControl;
        void askForPersonControlsVisibility(bool visible)
        {
            noPersonConstLabel.Visible = visible;
            RequirePersonPictureBox.Visible = visible;

            if (visible && cardControl is not null)
                cardControl.Visible = false;
        }
        public void AddPersonCard(IShowPersonUC card)
        {

            askForPersonControlsVisibility(false);

            cardControl = (Control)card;
            cardControl.Visible = true;

            cardControl.Dock = DockStyle.Bottom;
            Controls.Add(cardControl);

        }

        private void FilterPersonUC_Load(object sender, EventArgs e)
        {
         
        }
  
    }
    public class SearchByNationalNoEventArgs : EventArgs
        {
            public string NationalNo { get; }
            public PersonModel? Person { get; set; }

            public SearchByNationalNoEventArgs(string nationalNo)
            {
                NationalNo = nationalNo;
            }
        }
    public class SearchByIdEventArgs : EventArgs
        {

            public int PersonId { get; }
            public PersonModel? Person { get; set; }

            public SearchByIdEventArgs(int personId)
            {
                PersonId = personId;
            }
        }
}
