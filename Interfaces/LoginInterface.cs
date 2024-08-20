using TechExam.Models;

namespace TechExam.Interfaces
{
    public interface LoginInterface
    {
        Task RegisterUser(Users userData);
        Task<object> Login(string userName, string receivedPassword);
    }
}
