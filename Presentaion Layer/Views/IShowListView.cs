using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Views
{
    public interface IShowListView
    {
        event EventHandler AddToList;
        event EventHandler RemoveFromList;
        event EventHandler EditItemInList;
        event EventHandler Search;
        event EventHandler ShowDetailsForItem ;



        bool BasicEditOnly
        {
            get;
            set;
        }
        int SelectedIndex { get; }
        Image? ImageForAddBtn { get; set; }
        IList<string>? SearchBy { get; set; }
        string ListName { get; set; }
        string SearchByTxt { get ; set; }
        string SearchByCategory { get; }
        public string Head { set; get; }
        public int SelectedID { get; }

        void SetListBindingSource(BindingSource bs);

    }

}
