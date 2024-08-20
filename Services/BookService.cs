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
    public class BookService : BookInterface
    {
        private readonly ApplicationDbContext _db;

        public BookService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddNewBook(AddNewBook myNewBook)
        {
            if(myNewBook == null)
            {
                return;
            }

            var myData = new AddNewBook()
            {
                Title = myNewBook.Title,
                Author = myNewBook.Author,
                ISBN = myNewBook.ISBN,
                publishedDate = myNewBook.publishedDate,
            };

            _db.AddNewBook.Add(myData);
            await _db.SaveChangesAsync();
        }

        public async Task<object> UpdateUserBook(
            int id,
            UpdateBook updateMyBook)
        {
            var find = await _db.AddNewBook.FirstOrDefaultAsync(item => item.Id == id);

            if(find == null)
            {
                return null;
            }

            find.Title = updateMyBook.Title;
            find.Author = updateMyBook.Author;
            find.ISBN = updateMyBook.ISBN;
            find.publishedDate = updateMyBook.publishedDate;

            await _db.SaveChangesAsync();

            return "Successfully updated";
        }

        public async Task<AddNewBook> GetSpecificBook(int id)
        {
            if(id == null)
            {
                return null;
            }

            var findItem = await _db.AddNewBook.FirstOrDefaultAsync(item => item.Id == id);

            if(findItem == null)
            {
                return null;
            }

            return findItem;
        }

        public async Task<List<AddNewBook>> GetAllBooks()
        {
            var result = await _db.AddNewBook.ToListAsync();
            return result;
        }
    }
}
