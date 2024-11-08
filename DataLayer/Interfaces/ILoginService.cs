using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface ILoginService
    {
        LoginCredentials Login(LoginRequest request);
    }
}