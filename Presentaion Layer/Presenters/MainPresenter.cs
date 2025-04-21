using Presentaion_Layer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters
{
    internal class MainPresenter : IMainPresenter
    {
        IMainView _mainView;

        IShowPeopleListPresenter _showPeopleListPresenter;

    public MainPresenter(IMainView MainView, IShowPeopleListPresenter showPeopleListPresenter)
        {
            _mainView = MainView;
            _showPeopleListPresenter = showPeopleListPresenter;
            SubscribeToEvents();
        }
        private void SubscribeToEvents()
        {
            _mainView.ShowPeople += _mainView_ShowPeople;
        }


        public IMainView GetMainView() { return _mainView; }

        private void _mainView_ShowPeople(object? sender, EventArgs e)
        {
            _mainView.SetControlInUse((Control)_showPeopleListPresenter.GetShowPeopleList());
        }
    }
}
