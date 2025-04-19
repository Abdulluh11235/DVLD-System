using Presentaion_Layer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters
{
    internal class MainPresenter
    {
        IMainView _mainView;
        
        MainPresenter(IMainView MainView)
        {
            _mainView = MainView;
            SubscribeToEvents();
        }
        private void SubscribeToEvents()
        {
            _mainView.ShowPeople += _mainView_ShowPeople;
        }


        public IMainView GetMainView() { return _mainView; }

        private void _mainView_ShowPeople(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
