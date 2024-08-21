using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Text;
using TechExam.Data;
using TechExam.Models;
using BCrypt.Net;
using TechExam.Interfaces;

namespace TechExam.Services
{
    public class BookService : BookInterface
    {
        private readonly ApplicationDbContext _db;

        public BookService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<object> AddNewBook(Book myNewBook)
        {
            var myData = new Book()
            {
                Title = myNewBook.Title,
                Author = myNewBook.Author,
                ISBN = myNewBook.ISBN,
                publishedDate = myNewBook.publishedDate,
            };

            _db.Book.Add(myData);
            await _db.SaveChangesAsync();

            return "Successfully added new book";
        }

        public async Task<object> UpdateUserBook(
            int id,
            UpdateBook updateMyBook)
        {
            var find = await _db.Book.FirstOrDefaultAsync(item => item.Id == id);

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

        public async Task<Book> GetSpecificBook(int id)
        {
            var findItem = await _db.Book.FirstOrDefaultAsync(item => item.Id == id);

            if(findItem == null)
            {
                return null;
            }

            return findItem;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var result = await _db.Book.ToListAsync();
            return result;
        }
    }
}
