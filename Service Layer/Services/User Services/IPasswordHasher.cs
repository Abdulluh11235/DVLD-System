namespace Service_Layer.Services.User_Services
{
    public interface IPasswordHasher
    {
        string Hash(string pass);
        bool Verify(string pass, string passHash);
    }
}