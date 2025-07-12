using Domain_Layer.Models.User;

namespace Service_Layer.Interfaces.User
{
    public interface IUserServices
    {
        int? AddUser(UserModel user);
        public bool SignIn((string username, string password) credentials);
        bool DeleteUser(int id);
        Task< IEnumerable<UserModel>> GetAllUsers();
        Task<IEnumerable<UserModel>> GetByIsActive(bool isActive);
        Task<IEnumerable<UserModel>> GetUsersByUserName(string userName);
        UserModel? GetUserById(int id);
        bool UpdateUser(UserModel user);
    }
}