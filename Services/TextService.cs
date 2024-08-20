using TechExam.Data;
using TechExam.Models;
using Microsoft.EntityFrameworkCore;
using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using TechExam.Data;
using TechExam.Models;
using BCrypt.Net;


namespace TechExam.Services
{

    public class TextService : ITextService
    {
        private readonly ApplicationDbContext _db;

        public TextService (ApplicationDbContext db)
        {
            _db = db;
        }

        //public async Task RegisterUser(Users userData)
        //{

        //    if (userData == null)
        //        {
        //            return;
        //        }

        //    // Hash the user's password before storing it
        //    userData.PassWord = BCrypt.Net.BCrypt.HashPassword(userData.PassWord);

        //    var userRequest = new Users()
        //    {
        //        UserName = userData.UserName,
        //        PassWord = userData.PassWord, // Store the hashed password
        //        Balance = userData.Balance
        //    };

        //    _db.Users.Add(userRequest);
        //    await _db.SaveChangesAsync();

        //}

        //public async Task<object> Login(string userName, string receivedPassword)
        //{
        //    // Retrieve the user with the given username from the database
        //    var user = await _db.Users.FirstOrDefaultAsync(tr => tr.UserName == userName);

        //    Console.WriteLine(user);
        //    if (user != null && BCrypt.Net.BCrypt.Verify(receivedPassword, user.PassWord))
        //    {
        //        // Password matches; return the user
        //        return user;
        //    }

        //    var errorMessage = new errorMessage()
        //    {
        //        ErrorMessage = "User does not exist or incorrect password",
        //        ErrorSubMessage = "Please try again"
        //    };

        //    // Password doesn't match any user in the database
        //    return errorMessage;
        //}


        //public async Task<object> getUserBalance(string userName)
        //{
        //    var result = await _db.Users
        //        .Where(tr => tr.UserName == userName)
        //        .FirstOrDefaultAsync();

        //    if (result == null)
        //    {
        //        return null;
        //    }

        //    return result;
        //}

        //public async Task<object> UpdateUserData(string sender, string userName, int amount)
        //{
        //    // Get user that sends money
        //    var userSendingMoney = await _db.Users.FirstOrDefaultAsync(u => u.UserName == sender);

        //    if (userSendingMoney.Balance < amount)
        //    {
        //        var errorMessage = new errorMessage()
        //        {
        //            ErrorMessage = "Not Allowed",
        //            ErrorSubMessage = "Insufficient balance"
        //        };

        //        return errorMessage;
        //    }


        //    // Get the receiver
        //    var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == userName);


        //    if(user == null)
        //    {
        //        var errorMessage = new errorMessage()
        //        {
        //            ErrorMessage = "User not found",
        //            ErrorSubMessage = "Please try again"
        //        };

        //        return errorMessage;
        //    }
        //    // Update the user's balance
        //    user.Balance += amount;

        //    // Update the sender's balance
        //    userSendingMoney.Balance -= amount;

        //    // Save changes to the database
        //    await _db.SaveChangesAsync();


        //    var successMessage = new successMessage()
        //    {
        //        SuccessMessage = $"Money has been transferred successfully to: {user.UserName}",
        //    };

        //    return successMessage;
        //}

        //public async Task<object> depositAmountToCurrentUser(string currentUser, int amount)
        //{
        //    var User = await _db.Users.FirstOrDefaultAsync(u => u.UserName == currentUser);

        //    User.Balance += amount;

        //    // Save changes to the database
        //    await _db.SaveChangesAsync();
        //    return User;
        //}

        //public async Task<object> currentUserWithdrawCash(string currentUser, int withdrawalAmount)
        //{
        //    var User = await _db.Users.FirstOrDefaultAsync(u => u.UserName == currentUser);

        //    if(User.Balance < withdrawalAmount)
        //    {
        //        var errorMessage = new errorMessage()
        //        {
        //            ErrorMessage = "Not enough balance",
        //            ErrorSubMessage = "Please enter a new amount"
        //        };

        //        return errorMessage;
        //    }

        //    var successMessage = new successMessage()
        //    {
        //        SuccessMessage = "withdrawed money successfully"
        //    };

        //    User.Balance -= withdrawalAmount;
        //    await _db.SaveChangesAsync();

        //    return successMessage;
        //}

    }
}
