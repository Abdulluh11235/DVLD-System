
namespace Presentaion_Layer
{
    public interface ISignInView
    {
        (string username, string password) Credentials { get; }
        bool RememberMe { get; }

        event Predicate<(string username, string password)> CheckCredentials;
        event EventHandler SignInSucceeded;
    }
}