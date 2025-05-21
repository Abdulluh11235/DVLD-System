using Domain_Layer.Models.User;

namespace Service_Layer.Interfaces.User
{
    public interface IUserServices
    {
        int? AddUser(IUserModel user);
        public bool SignIn((string username, string password) credentials);
        bool DeleteUser(int id);
        IEnumerable<IUserModel> GetAllUsers();
        IEnumerable<IUserModel> GetByIsActive(bool isActive);
        IEnumerable<IUserModel> GetUsersByUserName(string userName);
        IUserModel? GetUserById(int id);
        bool UpdateUser(IUserModel user);
    }
}