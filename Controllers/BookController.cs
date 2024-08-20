using Microsoft.AspNetCore.Mvc;
using TechExam.Interfaces;
using TechExam.Services;
using TechExam.Models;

namespace TechExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly BookInterface _bookService;
        public BookController(BookInterface bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("addNewBook")]
        public async Task<IActionResult> addNewBookAsync([FromBody] AddNewBook myNewBook)
        {
            if(myNewBook == null)
            {
                return BadRequest("myNewBook is null");
            }

            await _bookService.AddNewBook(myNewBook);

            return Ok(new { message = "Successfully Added" });
        }

        [HttpPut("updateBook/{id}")]
        public async Task<IActionResult> UpdateUserData(
            int id,
            [FromBody] UpdateBook updateMyBook)
        {
            var result = await _bookService.UpdateUserBook(id, updateMyBook);
            return Ok(new { message = result });
        }

        [HttpGet("getSpecificBook/{id}")]
        public async Task<IActionResult> getSpecificBook(int id)
        {
            var output = await _bookService.GetSpecificBook(id);

            return Ok(new { book = output });
        }

        [HttpGet("getAllBooks")]
        public async Task<IActionResult> getAllBooks(int id)
        {
            var output = await _bookService.GetAllBooks();

            return Ok(new { allBooks = output });
        }

    }
}
