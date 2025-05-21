using Presentaion_Layer.Presenters.User;
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
        IShowUsersListPresenter _showUsersListPresenter;


        public MainPresenter(IMainView MainView, IShowPeopleListPresenter showPeopleListPresenter
            , IShowUsersListPresenter showUsersListPresenter)
        {
            _mainView = MainView;
            _showPeopleListPresenter = showPeopleListPresenter;
            _showUsersListPresenter = showUsersListPresenter;
            SubscribeToEvents();
        }
        private void SubscribeToEvents()
        {
            _mainView.ShowPeople += _mainView_ShowPeople;
            _mainView.ShowUsers += _mainView_ShowUsers;
        }

        private void _mainView_ShowUsers(object? sender, EventArgs e)
        {
            _mainView.SetControlInUse((Control)_showUsersListPresenter.GetShowUsersList());
        }

        public IMainView GetMainView() { return _mainView; }

        private void _mainView_ShowPeople(object? sender, EventArgs e)
        {
            _mainView.SetControlInUse( (Control)_showPeopleListPresenter.GetShowPeopleList() );
        }
    }
}
