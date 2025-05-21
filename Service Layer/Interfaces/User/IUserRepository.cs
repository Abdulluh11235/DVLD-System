using Domain_Layer.Models.User;

namespace Service_Layer.Interfaces.User
{
    public interface IUserRepository
    {
        int? AddUser(IUserModel user);
        bool DeleteUser(int id);
        IEnumerable<IUserModel> GetAllUsers();
        IEnumerable<IUserModel> GetByIsActive(bool isActive);
        IEnumerable<IUserModel> GetUsersByUserName(string userName);
        IUserModel? GetUserByUserName(string username);
        IUserModel? GetUserById(int id);
        bool UpdateUser(IUserModel user);
    }
}