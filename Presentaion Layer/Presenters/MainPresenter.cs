using Presentaion_Layer.Presenters.Application;
using Presentaion_Layer.Presenters.Test;
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
     readonly  IMainView _mainView;
     readonly IShowApplicationTypesList _showApplicationTypesList ;
     readonly IShowPeopleListPresenter _showPeopleListPresenter;
     readonly IShowUsersListPresenter _showUsersListPresenter;
     readonly IShowTestTypesListPresenter _showTestTypesListPresenter;


        public MainPresenter(IMainView MainView, IShowPeopleListPresenter showPeopleListPresenter
            , IShowUsersListPresenter showUsersListPresenter, IShowApplicationTypesList showApplicationTypesList
            ,IShowTestTypesListPresenter showTestTypesListPresenter)
        {
            _mainView = MainView;
            _showPeopleListPresenter = showPeopleListPresenter;
            _showTestTypesListPresenter = showTestTypesListPresenter;
            _showUsersListPresenter = showUsersListPresenter;
            _showApplicationTypesList = showApplicationTypesList;
            SubscribeToEvents();
        }
        private void SubscribeToEvents()
        {
            _mainView.ShowPeople += _mainView_ShowPeople;
            _mainView.ShowUsers += _mainView_ShowUsers;
            _mainView.ShowApplicationTypes += _mainView_ShowApplicationTypes;
            _mainView.ShowTestTypes += _mainView_ShowTestTypes;
        }

        private void _mainView_ShowTestTypes(object? sender, EventArgs e)
        {
           _mainView.SetControlInUse((Control)_showTestTypesListPresenter.GetShowTestTypesListView());
        }

        private void _mainView_ShowApplicationTypes(object? sender, EventArgs e)
        {
            _mainView.SetControlInUse((Control)_showApplicationTypesList.GetShowApplicationTypesListView());
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
