﻿
using Domain_Layer;
using Domain_Layer.Models.User;
using Presentaion_Layer.Views.People;
using Presentaion_Layer.Presenters.Person;

namespace Presentaion_Layer.Views.Users
{
    public interface IAddEditUserView
    {
        public event Func<UserModel, int?>? addUserInDB;
        public event Predicate<UserModel?>? updateUserInDB;

        public event EventHandler<UserModel?>? DataBack;
        public void addPersonFilterCard(IFilterPersonUC filterPersonUC);
        public UserModel? UserModel { set; get; }
        public PersonModel? PersonModel { set; get; }

    }
}