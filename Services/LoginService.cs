using Microsoft.EntityFrameworkCore;
using TechExam.Data;
using TechExam.Models;
using TechExam.Interfaces;

namespace TechExam.Services
{
    public class LoginService : LoginInterface
    {
        private readonly ApplicationDbContext _db;

        public LoginService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task RegisterUser(Users userData)
        {
            if(userData == null)
            {
                return;
            }

            userData.PassWord = BCrypt.Net.BCrypt.HashPassword(userData.PassWord);

            var userRequest = new Users()
            {
                UserName = userData.UserName,
                PassWord = userData.PassWord,
            };

            _db.Users.Add(userRequest);
            await _db.SaveChangesAsync();
        }

        public async Task<object> Login(string userName, string receivedPassword)
        {
            var user = await _db.Users.FirstOrDefaultAsync(tr => tr.UserName == userName);

            Console.WriteLine(user);
            if (user != null && BCrypt.Net.BCrypt.Verify(receivedPassword, user.PassWord))
            {
                return user;
            }

            var errorMessage = new errorMessage()
            {
                ErrorMessage = "User does not exist or incorrect password",
                ErrorSubMessage = "Please try again"
            };

            return errorMessage;
        }
    }
}
