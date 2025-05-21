using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer;

public partial class SignInForm : Form, ISignInView
{
    public event Predicate<(string username, string password)> CheckCredentials;
    public event EventHandler SignInSucceeded;
    public bool RememberMe => RememberMeCheckBox.Checked;
    public SignInForm()
    {
        InitializeComponent();
    }

    private void SignInButton_Click(object sender, EventArgs e)
    {
        if (CheckCredentials((UserNameTextBox.Text, PasswordMaskedTextBox.Text)))
        {
            SignInSucceeded(this, EventArgs.Empty);
            Close();
        }
        else
            MessageBox.Show("Invalid Username /Password");
    }
}
