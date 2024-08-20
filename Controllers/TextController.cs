using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using TechExam.Data;
using TechExam.Models;
using TechExam.Services;

namespace TechExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {

        private readonly ITextService _textService;
        private readonly SubDataInterface _subDataInterface;

        public TextController(ITextService textService,SubDataInterface subDataInterface)
        {
            _textService = textService;
            _subDataInterface = subDataInterface;
        }


        //[HttpPost("registerUser")]
        //public async Task<IActionResult> registerUserAsync([FromBody] Users userData)
        //{
        //    Console.WriteLine("TEST");
        //    if (userData == null)
        //    {
        //        return BadRequest("textData is null");
        //    }

        //    await _textService.RegisterUser(userData);
        //    var resulat = _subDataInterface.TestingOfInterface(321);

        //    var SuccessMessage = new successMessage()
        //    {
        //        SuccessMessage = "User successfully registered",
        //        SuccessSubMessage = "You can now log in"
        //    };

        //    return Ok(new { successMessage = SuccessMessage });
        //}
        //[HttpGet("login")]
        //public async Task<IActionResult> Login([FromQuery] string userName, [FromQuery] string passWord)
        //{
        //    var output = await _textService.Login(userName, passWord);

        //    return Ok(new { loginMessage = output });
        //}



        //[HttpGet("getUserBalance")]
        //public async Task<IActionResult> getUserBalanceAsync([FromQuery] string userName)
        //{
            
        //    var output = await _textService.getUserBalance(userName);

        //    return Ok(new { userBalance = output });
        //}

        //[HttpPut("updateUserData/{userName}")]
        //public async Task<IActionResult> UpdateUserData([FromQuery] string sender, string userName, [FromQuery] int amount)
        //{

        //    var output = await _textService.UpdateUserData(sender, userName, amount);
            
        //    // Retrieve the user by userName from the database

        //    return Ok(new { message = output}); // Return the updated user
        //}

        //[HttpPut("updateCurrentUserBalance/{currentUser}")]
        //public async Task<IActionResult> depositAmountToCurrentUser(string currentUser, [FromQuery] int depositAmount)
        //{
        //    var output = await _textService.depositAmountToCurrentUser(currentUser, depositAmount); 
        //    return Ok(new {message = "depositted successfully"});
        //}

        //[HttpPut("withdrawCurrentUserBalance/{currentUser}")]
        //public async Task<IActionResult> currentUserWithdrawCash(string currentUser, [FromQuery] int withdrawalAmount)
        //{
        //    var output = await _textService.currentUserWithdrawCash(currentUser, withdrawalAmount);

        //    return Ok(new {message = output});
        //}


    }
}
