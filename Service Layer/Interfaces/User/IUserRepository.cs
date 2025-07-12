using Domain_Layer.Models.User;

namespace Service_Layer.Interfaces.User
{
    public interface IUserRepository
    {
        int? AddUser(UserModel user);
        bool DeleteUser(int id);
       Task< IEnumerable<UserModel> >GetAllUsers();
       Task<IEnumerable<UserModel> > GetByIsActive(bool isActive);
       Task< IEnumerable<UserModel>> GetUsersByUserName(string userName);
        UserModel? GetUserByUserName(string username);
        UserModel? GetUserById(int id);
        bool UpdateUser(UserModel user);
    }
}