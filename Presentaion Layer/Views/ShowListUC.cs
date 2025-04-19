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
        public IEnumerable<string>? SearchBy
        {
            get => SearchByComboBox.DataSource as IEnumerable<string> ?? new List<string>();
            set
            {
                if (value != null && ! value.Any() ) 
                   throw new ArgumentException("DataSource cannot be empty.");
                SearchByComboBox.DataSource = value;
            }
        }


        public ShowListUC()
        {
           InitializeComponent();
        }


        public void SetListBindingSource(BindingSource bs)
        {
            DataGridView.DataSource = bs;
        }
    }
}
