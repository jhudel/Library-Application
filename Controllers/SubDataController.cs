using Microsoft.AspNetCore.Mvc;
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
    public class SubDataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpPost("SubDataTest")]
        //public async Task<IActionResult> subTesting([FromBody] Users data)
        //{
        //    var userData = new Users()
        //    {
        //        UserName = data.UserName,
        //        PassWord = data.PassWord,
        //        Balance = data.Balance
        //    };

        //    Console.WriteLine($"Data1 {userData.UserName}");
        //    Console.WriteLine($"Data2 {userData.PassWord}");
        //    Console.WriteLine($"Data3 {userData.Balance}");
        //    return Ok();
        //}
    }
}
