using Service_Layer.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters.User
{
    internal class SignInPresenter : ISignInPresenter
    {
        private readonly ISignInView _signInView;
        private readonly IMainPresenter _mainPresenter;
        private readonly IUserServices _userServices;

        public SignInPresenter(ISignInView signInView, IMainPresenter mainPresenter,
            IUserServices userServices)
        {
            _signInView = signInView;
            _mainPresenter = mainPresenter;
            _userServices = userServices;
            _signInView.SignInSucceeded += _signInView_SignInSucceeded;
            _signInView.CheckCredentials += _signInView_CheckCredentials;
        }
        private void SetUp()
        {
        }

        private bool _signInView_CheckCredentials((string username, string password) cred)
        {
            return _userServices.SignIn(cred);
        }

        private void _signInView_SignInSucceeded(object? sender, EventArgs e)
        {
            //TODO:Check Remember Me & save creds in some place  
            Form mainF = (Form)_mainPresenter.GetMainView();
            mainF.Show();
        }

        public ISignInView GetView()
        {
            return _signInView;
        }


    }
}
