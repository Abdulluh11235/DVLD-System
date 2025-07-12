using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPeople;
        public event EventHandler ShowApplicationTypes;
        public event EventHandler ShowTestTypes; 

        void SetControlInUse(Control control);
        event EventHandler ShowUsers;

    }
}
