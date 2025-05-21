using Domain_Layer.Models.User;
using Presentaion_Layer.Presenters.Person;
using Presentaion_Layer.Properties;
using Presentaion_Layer.Views;
using Service_Layer.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentaion_Layer.Presenters.User
{
    internal class ShowUsersListPresenter : BaseShowListPresenter<IUserModel, IUserServices>, IShowUsersListPresenter
    {
        private readonly IShowItemPresenter _showUserPresenter;

        public ShowUsersListPresenter(
            IShowListView showListView,
            IUserServices userServices,
            IShowItemPresenter showUserPresenter)
            : base(showListView, userServices)
        {
            _showUserPresenter = showUserPresenter;
        }

        protected override void InitializeSearchHandlers()
        {
            _searchHandlers.Add("User ID", SearchByUserId);
        }

        protected  override void Setup()
        {
            base.Setup();

            _showListView.ImageForAddBtn = Resources.user_with_add_sign__3_;
            _showListView.Head = "Manage Users";

            var users =  _services.GetAllUsers();
            UpdateList(users);

            _showListView.HideColumn("Person");
            _showListView.HideColumn("HashedPassword");

            _showListView.Search += _showListView_Search;
            _showListView.ShowDetailsForItem += _showListView_ShowDetailsForItem;
        }

        private void _showListView_ShowDetailsForItem(object? sender, EventArgs e)
        {
        
        }


        private void _showListView_Search(object? sender, EventArgs e)
        {
            if (_searchHandlers.TryGetValue(_showListView.SearchByCategory, out var handler))
            {
                handler.Invoke();
                _showListView.HideColumn("Person");
            }
        }

        private  void SearchByUserId()
        {
            if (int.TryParse(_showListView.SearchByTxt, out int id))
            {
                var user =  _services.GetUserById(id);
                UpdateList(user != null ? new[] { user } : Array.Empty<IUserModel>());
            }
            else if (string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
            {
                var users =  _services.GetAllUsers();
                UpdateList(users);
            }
            else
            {
                MessageBox.Show("Input Must Be An ID Number");
            }
        }


        public IShowListView GetShowUsersList() => _showListView;
    }
}