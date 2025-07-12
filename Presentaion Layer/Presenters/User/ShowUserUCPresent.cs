using Domain_Layer;
using Domain_Layer.Models.User;
using Presentaion_Layer.Presenters.Person;
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
    internal class ShowUserUCPresent : IShowUserUCPresent
    {
        readonly IShowUserUC _showUserUC;
        readonly IUserServices _userServices;

        public int UserID { get; set; }
        //     readonly IAddEditUserPresenter _addEditUserPresenter;
        public ShowUserUCPresent(IShowUserUC showUserUC, IUserServices userServices)
        {
            _showUserUC = showUserUC;
            _userServices = userServices;
        }
        bool notSubscribed = true;
        public IShowUserUC GetView()
        {
            UserModel? user = _userServices.GetUserById(UserID);

            if (notSubscribed)
            {
                //     _showUserUC.showEdit += _showPersonUC_showEdit;
                notSubscribed = false;
            }


            if (user is null) throw new Exception("Can\'t Show Form Without a Person");

            _showUserUC.User = user;
            return _showUserUC;
        }

        //private void _showUserUC_showEdit(object? sender, EventArgs e)
        //{

        //    IAddEditUserPresenter editView = _addEditUserPresenter.GetView();
        //    editView.PersonModel = _showPersonUC.PersonModel;

        //    Form editForm = (Form)editView;
        //    editForm.ShowDialog();
        //}


    }
}
