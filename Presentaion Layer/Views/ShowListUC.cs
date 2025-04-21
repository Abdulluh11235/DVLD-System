using Presentaion_Layer.Common_For_Coloring___Themes;
using Presentaion_Layer.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaion_Layer
{
    public partial class ShowListUC : UserControl,IShowListView
    {
        public event EventHandler AddToList=delegate { };
        public event EventHandler RemoveFromList=delegate { };
        public event EventHandler EditItemInList=delegate { };
        public event EventHandler Search=delegate { };

   
        public Image? ImageForAddBtn { get => AddBtn.Image; 
            set => AddBtn.Image = value; }
        public IList<string>? SearchBy
        {
            get => SearchByComboBox.DataSource as List<string> ?? new List<string>();
            set
            {
                if (value != null && ! value.Any() ) 
                   throw new ArgumentException("DataSource cannot be empty.");
                SearchByComboBox.DataSource = value;
            }
        }
        public string ListName { get => ListNameLabel.Text; set => ListNameLabel.Text = value; }
        public string SearchByTxt { get => SearchTextBox.Text; set => SearchTextBox.Text = value; }




        public ShowListUC()
        {
           InitializeComponent();
            DataGridView.DefaultCellStyle.BackColor=Themes.DarkMode().BackgroundColor;
            DataGridView.DefaultCellStyle.ForeColor = Themes.DarkMode().FontColor;
        //    DataGridView. = Themes.DarkMode().AccentColor;

        }


        public void SetListBindingSource(BindingSource bs)
        {
            DataGridView.DataSource = bs;
        }
    }
}
