using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Text;
using TechExam.Data;
using TechExam.Models;
using BCrypt.Net;
using TechExam.Interfaces;
using TechExam.Models;

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

            // Hash the user's password before storing it
            userData.PassWord = BCrypt.Net.BCrypt.HashPassword(userData.PassWord);

            var userRequest = new Users()
            {
                UserName = userData.UserName,
                PassWord = userData.PassWord, // Store the hashed password
            };

            _db.Users.Add(userRequest);
            await _db.SaveChangesAsync();
        }

        public async Task<object> Login(string userName, string receivedPassword)
        {
            // Retrieve the user with the given username from the database
            var user = await _db.Users.FirstOrDefaultAsync(tr => tr.UserName == userName);

            Console.WriteLine(user);
            if (user != null && BCrypt.Net.BCrypt.Verify(receivedPassword, user.PassWord))
            {
                // Password matches; return the user
                return user;
            }

            var errorMessage = new errorMessage()
            {
                ErrorMessage = "User does not exist or incorrect password",
                ErrorSubMessage = "Please try again"
            };

            // Password doesn't match any user in the database
            return errorMessage;
        }
    }
}
