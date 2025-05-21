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

        public int? AddUser(IUserModel user)
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

        public IEnumerable<IUserModel> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public IEnumerable<IUserModel> GetByIsActive(bool isActive)
        {
            return _userRepository.GetByIsActive(isActive);
        }

        public IEnumerable<IUserModel> GetUsersByUserName(string userName)
        {
            NoEmptyORNull(userName);
            return _userRepository.GetUsersByUserName(userName);
        }

        public IUserModel? GetUserById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            return _userRepository.GetUserById(id);
        }

        public bool UpdateUser(IUserModel user)
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
            IUserModel? user = _userRepository.GetUserByUserName(credentials.username);
            if(user is null)  return false;
         
            return  _passwordHasher.Verify(credentials.password,user.HashedPassword);
       }

    }
}