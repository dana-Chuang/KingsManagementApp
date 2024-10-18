using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface ILoginService
    {
        Boolean Login(LoginRequest request);
    }
}