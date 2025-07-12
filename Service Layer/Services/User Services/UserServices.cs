using Domain_Layer.Models.User;
using Service_Layer.Common_Services;
using Service_Layer.Interfaces.User;
using Service_Layer.Services.User_Services;

namespace Service_Layer
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;
        private readonly IPasswordHasher _passwordHasher;   

        public UserServices(IUserRepository userRepository,IPasswordHasher passwordHasher,
            IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _userRepository = userRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _passwordHasher = passwordHasher;
        }

        public int? AddUser(UserModel user)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(user);
            user.HashedPassword = _passwordHasher.Hash(user.HashedPassword);
            return _userRepository.AddUser(user);
        }

        public bool DeleteUser(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            return _userRepository.DeleteUser(id);
        }

        public async Task<IEnumerable<UserModel>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async  Task<IEnumerable<UserModel>> GetByIsActive(bool isActive)
        {
            return await _userRepository.GetByIsActive(isActive);
        }

        public async Task<IEnumerable<UserModel>> GetUsersByUserName(string userName)
        {
            return await _userRepository.GetUsersByUserName(userName);
        }

        public UserModel? GetUserById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            return _userRepository.GetUserById(id);
        }

        public bool UpdateUser(UserModel user)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(user);
            return _userRepository.UpdateUser(user);
        }
        private void NoEmptyORNull(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be null or empty.", nameof(value));
        }
       public bool SignIn((string username,string password) credentials )
       {
            UserModel? user = _userRepository.GetUserByUserName(credentials.username);
            if(user is null)  return false;
         
            return  _passwordHasher.Verify(credentials.password,user.HashedPassword);
       }

    }
}