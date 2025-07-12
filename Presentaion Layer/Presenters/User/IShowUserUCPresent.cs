using Presentaion_Layer.Views.Users;

namespace Presentaion_Layer.Presenters.User
{
    internal interface IShowUserUCPresent
    {
        int UserID { get; set; }

        IShowUserUC GetView();
    }
}