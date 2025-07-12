using Domain_Layer.Models.Application;
using Domain_Layer.Models.Test;
using Presentaion_Layer.Views.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer.Views.Tests;

public delegate Task<bool> TestTypeModelSavedHandler(TestTypeModel model);
public partial class TestTypeEditView : Form, ITestTypeEditView
{
    public event TestTypeModelSavedHandler? TestTypeSavedInDB;
    public event EventHandler<TestTypeModel?> DataBack = delegate { };

    public TestTypeModel TestType { get; set; }
    public TestTypeEditView()
    {
        InitializeComponent();

    }
    private void refillTestType()
    {
        TestType.Id = Convert.ToInt32(testTypeIDLabel.Text);
        TestType.Name = testTypeNameTextBox.Text;
        TestType.Description = testTypeDescriptionTextbox.Text;
        TestType.Fees = Convert.ToInt32(testTypeFeesTextBox.Text);
    }

    private void TestTypeEditView_Load(object sender, EventArgs e)
    {
        testTypeIDLabel.Text = TestType.Id.ToString();
        testTypeNameTextBox.Text = TestType.Name;
        testTypeDescriptionTextbox.Text = TestType.Description;
        testTypeFeesTextBox.Text = TestType.Fees.ToString();
    }

    private async void SaveButton_Click(object sender, EventArgs e)
    {
        if (TestTypeSavedInDB is null) { throw new NullReferenceException(nameof(TestTypeSavedInDB)); }
        refillTestType();
        if (await TestTypeSavedInDB.Invoke(TestType))
        {
            MessageBox.Show($"Test Type With Id {TestType.Id}  has been updated sucessfuly");
            DataBack(this, TestType);
            Close();
        }
        else
        {
            MessageBox.Show("Something Went Wrong");
        }

    }


}





