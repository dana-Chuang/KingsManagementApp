using DataLayer.Interfaces;

namespace DataLayer.Interfaces
{
    public interface ILoginRepository
    {
        IEnumerable<String> GetPassword(string username);
    }
}