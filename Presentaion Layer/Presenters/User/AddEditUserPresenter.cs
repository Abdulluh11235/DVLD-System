using Domain_Layer;
using Domain_Layer.Models.User;
using Presentaion_Layer.Presenters.Person;
using Presentaion_Layer.Views;
using Presentaion_Layer.Views.People;
using Presentaion_Layer.Views.Users;
using Service_Layer;
using Service_Layer.Interfaces.Person;
using Service_Layer.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters.User
{
    public class AddEditUserPresenter : IAddEditUserPresenter
    {
        IUserServices _userServices;
        IPersonServices _personServices;
        IShowPersonUCPresenter _showPersonUCPresenter;
        IAddEditUserView _addUserView;

        public AddEditUserPresenter(IAddEditUserView addUserView, IUserServices userServices,
            IPersonServices personServices, IShowPersonUCPresenter showPersonUCPresenter)
        {
            _userServices = userServices;
            _personServices = personServices;
            _showPersonUCPresenter = showPersonUCPresenter;
            _addUserView = addUserView;
            SetUp();
        }

        private void SetUp()
        {
            _addUserView.SearchForPersonNationalNo += _addUserView_SearchForPersonNationalNo;
            _addUserView.SearchForPersonID += _addUserView_SearchForPersonID;
            _addUserView.addUserInDB += _addUserView_addUserInDB;
            _addUserView.updateUserInDB += _addUserView_updateUserInDB;
        }

        private bool _addUserView_updateUserInDB(UserModel? user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            return _userServices.UpdateUser(user);
        }

    private int? _addUserView_addUserInDB(UserModel userModel)
        {
            if (userModel is not null) return _userServices.AddUser(userModel);
            else throw new ArgumentNullException(nameof(userModel)); 
        }

        private void _addUserView_SearchForPersonID(object? sender, SearchByIdEventArgs e)
        {
            PersonModel? p = _personServices.GetPersonById(e.PersonId);
            if (p != null)
            {
                e.Person = p;
                _showPersonUCPresenter.PersonId = e.PersonId;
                 _addUserView.PersonModel=p;
               _addUserView.AddPersonCard(_showPersonUCPresenter.GetView() );
            }

        }

        private void _addUserView_SearchForPersonNationalNo(object? sender, SearchByNationalNoEventArgs e)
        {
            PersonModel? p = _personServices.GetPersonByNationalNo(e.NationalNo);

            if (p != null)
            {
                e.Person = p;
                _showPersonUCPresenter.PersonId=p.PersonID;
                _addUserView.PersonModel = p;
                _addUserView.AddPersonCard(_showPersonUCPresenter.GetView());
            }

        }

        public IAddEditUserView GetView() {  return _addUserView; }
    }
}
