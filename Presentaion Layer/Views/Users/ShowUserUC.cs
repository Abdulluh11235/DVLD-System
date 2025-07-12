using Domain_Layer;
using Domain_Layer.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer.Views.Users
{
    public partial class ShowUserUC : UserControl, IShowUserUC
    {
        public UserModel? User { get; set; }
        public event EventHandler? showEdit;

        public ShowUserUC()
        {
            InitializeComponent();
        }


        private void userInfo_Enter(object sender, EventArgs e)
        {

        }

        private void ShowUserUC_Load(object sender, EventArgs e)
        {
            if (User is null) { throw new NullReferenceException(); }
            else
            {
                userIdLabel.Text=User.UserID.ToString();
                userNameLabel.Text = User.UserName;
                activeLabel.Text = (User.Active) ? "Active" : "Not Active";
            }
        }
    }
}
