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
        IAddEditUserView _addUserView;
        IfilterPersonUCPresenter _filterPersonUCPresenter;
        

        public AddEditUserPresenter(IAddEditUserView addUserView, 
            IUserServices userServices,
            IfilterPersonUCPresenter filterPersonUCPresenter)
        {
            _userServices = userServices;
            _addUserView = addUserView;
            _filterPersonUCPresenter = filterPersonUCPresenter;
            SetUp();
        }

        private void SetUp()
        {
            _addUserView.addUserInDB += _addUserView_addUserInDB;
            _addUserView.updateUserInDB += _addUserView_updateUserInDB;
        }

        private bool _addUserView_updateUserInDB(UserModel? user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return _userServices.UpdateUser(user);
        }

    private int? _addUserView_addUserInDB(UserModel userModel)
        {
            if (userModel is not null) return _userServices.AddUser(userModel);
            else throw new ArgumentNullException(nameof(userModel)); 
        }



        public IAddEditUserView GetView() {  return _addUserView; }
    }
}
