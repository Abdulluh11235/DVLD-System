
namespace Presentaion_Layer
{
    public interface ISignInView
    {
        bool RememberMe { get; }
        void Close();
        event Predicate<(string username, string password)> CheckCredentials;
        event EventHandler SignInSucceeded;
    }
}