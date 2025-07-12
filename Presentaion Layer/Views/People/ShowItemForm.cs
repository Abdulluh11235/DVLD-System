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
public partial class ShowItemForm : Form, IShowItemForm
{
   
    public ShowItemForm()
    {
        InitializeComponent();
    }

    public void AddControl(Control c)
    {
        c.Dock = DockStyle.Top;
            Controls.Add(c);
    }
    private void ShowPersonForm_Load(object sender, EventArgs e)
    {

    }
}
