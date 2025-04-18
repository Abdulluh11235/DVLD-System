﻿using System;
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

        Image? ImageForAddBtn { get; set; }
        IEnumerable<string>? SearchBy { get; set; }

        void SetListBindingSource(BindingSource bs);
    }

}
