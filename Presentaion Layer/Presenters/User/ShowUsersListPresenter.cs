using Domain_Layer.Models.User;
using Microsoft.VisualBasic.ApplicationServices;
using Presentaion_Layer.Presenters.Person;
using Presentaion_Layer.Properties;
using Presentaion_Layer.Views;
using Presentaion_Layer.Views.People;
using Presentaion_Layer.Views.Users;
using Service_Layer;
using Service_Layer.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentaion_Layer.Presenters.User
{
    internal class ShowUsersListPresenter : BaseShowListPresenter<UserModel, IUserServices>, IShowUsersListPresenter
    {
        private readonly IShowItemPresenter _showUserPresenter;
        private readonly IAddEditUserPresenter _addEditUserPresenter;
        private readonly IShowPersonUCPresenter _showPersonUCPresenter;
        private readonly IShowUserUCPresent _showUserUCPresenter;
        private readonly IfilterPersonUCPresenter _filterPersonUCPresenter;



        public ShowUsersListPresenter(
            IShowListView showListView,
            IUserServices userServices,
            IShowItemPresenter showUserPresenter,
            IAddEditUserPresenter addEditUserPresenter,IfilterPersonUCPresenter filterPersonUCPresenter,
            IShowPersonUCPresenter showPersonUCPresenter, IShowUserUCPresent showUserUCPresent)
            : base(showListView, userServices)
        {
            _showUserPresenter = showUserPresenter;
            _showUserUCPresenter= showUserUCPresent;
            _filterPersonUCPresenter= filterPersonUCPresenter;
            _showPersonUCPresenter = showPersonUCPresenter; 
            _addEditUserPresenter = addEditUserPresenter;
        }

        protected override void InitializeSearchHandlers()
        {
            _searchHandlers.Add("User ID", SearchByUserId);
        }

        protected  override async void Setup()
        {
            base.Setup();

            _showListView.ImageForAddBtn = Resources.user_with_add_sign__3_;
            _showListView.Head = "Manage Users";

            var users =  await _services.GetAllUsers();
            UpdateList(users);


            _showListView.Search += _showListView_Search;
            _showListView.AddToList += _showListView_AddToList;
            _showListView.RemoveFromList += _showListView_RemoveFromList;
           _showListView.EditItemInList += _showListView_EditItemInList;
            _showListView.ShowDetailsForItem += _showListView_ShowDetailsForItem;
        }

        bool notSubscribedEdit=true;
        private void _showListView_EditItemInList(object? sender, EventArgs e)
        {

            var _editUserView = _addEditUserPresenter.GetView();
            var user = _services.GetUserById(_showListView.SelectedID);
            if (user == null) throw new ArgumentNullException("user");
            _editUserView.UserModel= user;
            _editUserView.PersonModel = user.Person;
            _showPersonUCPresenter.PersonId=user.PersonId;
           var  filterCard = _filterPersonUCPresenter.GetView();
            filterCard.AddPersonCard(_showPersonUCPresenter.GetView());

            filterCard.PersonModel = user.Person;
            _editUserView.addPersonFilterCard(filterCard);


            if (notSubscribedEdit)
            {
                _editUserView.DataBack += EditForm_DataBack;
                notSubscribedEdit = false;
            }

            if (firstTimeEver) { firstTimeEver = false; ((Form)_editUserView).ShowDialog();  
                lastSubscribed = Mode.Edit;  return; }

            if (lastSubscribed != Mode.Edit)
            {
                _editUserView.DataBack -= AddForm_DataBack;
            }
         
            lastSubscribed= Mode.Edit;
            ((Form)_editUserView).ShowDialog();
        }

       


        private void EditForm_DataBack(object? sender, UserModel? updatedUser)
        {

            last[_showListView.SelectedIndex] = updatedUser;
        }

        private void _showListView_RemoveFromList(object? sender, EventArgs e)
        {
            // Message boxes should be in view not here
            if (_services.DeleteUser(_showListView.SelectedID))
            {
                MessageBox.Show($"User With Id {_showListView.SelectedID} Was Successfully Deleted");
                last.RemoveAt(_showListView.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
        
        bool firstTimeEver=true;
        bool notSubscribedAdd = true;
        Mode lastSubscribed;

        private void _showListView_AddToList(object? sender, EventArgs e)
        {
            var addForm = _addEditUserPresenter.GetView();
            addForm.UserModel = null; // add mode & controls vis
            addForm.PersonModel =null;
            var filterCard = _filterPersonUCPresenter.GetView();
            filterCard.PersonModel=null;
            addForm.addPersonFilterCard(filterCard);
           

            if (notSubscribedAdd)
            {
                addForm.DataBack += AddForm_DataBack;
                notSubscribedAdd = false;
            }
                 
     

            if (firstTimeEver) { firstTimeEver = false;  lastSubscribed= Mode.Add; ((Form)addForm).ShowDialog(); return; }
                 
              if (lastSubscribed!=Mode.Add) {
                addForm.DataBack -= EditForm_DataBack;
            }
              
              lastSubscribed = Mode.Add;
              ((Form)addForm).ShowDialog();

        }

        private void AddForm_DataBack(object? sender, UserModel? userModel)
        {
            if (userModel is not null) 
                last.Add(userModel);
        }

        private void _showListView_ShowDetailsForItem(object? sender, EventArgs e) //refactor
        {
            int id = _showListView.SelectedID;
           _showUserUCPresenter.UserID = id;
            var showUserControl = _showUserUCPresenter.GetView();

            var showUserForm = _showUserPresenter.ShowView();
            
           _showPersonUCPresenter.PersonId=showUserControl.User!.Person.PersonID;
            var showPersonControl = _showPersonUCPresenter.GetView();


            showUserForm.AddControl((Control)showUserControl);
            showUserForm.AddControl((Control)showPersonControl);


            ((Form)showUserForm).ShowDialog();
        }


        private void _showListView_Search(object? sender, EventArgs e)
        {
            if (_searchHandlers.TryGetValue(_showListView.SearchByCategory, out var handler))
            {
                handler.Invoke();
            }
        }

        private   async void SearchByUserId()
        {
            if (int.TryParse(_showListView.SearchByTxt, out int id))
            {
                var user =   _services.GetUserById(id);
                UpdateList(user != null ? new[] { user } : Array.Empty<UserModel>());
            }
            else if (string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
            {
                var users = await _services.GetAllUsers();
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