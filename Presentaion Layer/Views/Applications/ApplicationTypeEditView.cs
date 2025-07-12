using Domain_Layer;
using Domain_Layer.Models.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer.Views.Applications
{
    public  delegate Task<bool> ApplicationTypeSavedHandler(ApplicationTypeModel model);
    public partial class ApplicationTypeEditView : Form, IApplicationTypeEditView
    {

        public event ApplicationTypeSavedHandler? ApplicationTypeSavedInDB ;
        public event EventHandler<ApplicationTypeModel?> DataBack = delegate { };
        public ApplicationTypeModel applicationType { get; set; }
        public ApplicationTypeEditView()
        {
            InitializeComponent();

        }
        private void refillApplicationType()
        {
            applicationType.Id = Convert.ToInt32(applicationTypeIDLabel.Text);
            applicationType.Name = applicationTypeNameTextBox.Text;
            applicationType.Fees =Convert.ToInt32( applicationTypeFeesTextBox.Text);
        }
        private void ApplicationTypeEditView_Load(object sender, EventArgs e)
        {
            applicationTypeIDLabel.Text = applicationType.Id.ToString();
            applicationTypeNameTextBox.Text = applicationType.Name;
            applicationTypeFeesTextBox.Text = applicationType.Fees.ToString();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            refillApplicationType();
            if ( await ApplicationTypeSavedInDB.Invoke(applicationType))
            {
                MessageBox.Show($"Application Type With Id {applicationType.Id}  has been updated sucessfuly");
                DataBack(this, applicationType);
                Close();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
    }
}
