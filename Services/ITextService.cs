using TechExam.Models;
using static TechExam.Services.TextService;

namespace TechExam.Services
{
    public interface ITextService
    {
       
        //Task RegisterUser(Users userData);
        //Task<object> Login(string userName, string receivedPassword);

        //Task<object> getUserBalance(string userName);

        //Task<object> UpdateUserData(string sender, string userName, int amount);

        //Task<object> depositAmountToCurrentUser(string currentUser, int amount);

        //Task<object> currentUserWithdrawCash(string currentUser, int withdrawalAmount);
    }

    public interface ITextService2
    {
        public void DisplayMessage();
    }
}
