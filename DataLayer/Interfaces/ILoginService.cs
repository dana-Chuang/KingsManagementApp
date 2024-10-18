using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface ILoginService
    {
        void Login(LoginRequest request);
    }
}