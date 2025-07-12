using Domain_Layer.Models.User;

namespace Presentaion_Layer.Views.Users
{
    public interface IShowUserUC
    {
        UserModel? User { get; set; }

        event EventHandler? showEdit;
    }
}