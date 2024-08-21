using TechExam.Models;

namespace TechExam.Interfaces
{
    public interface BookInterface
    {
        public Task<object> AddNewBook(Book myNewBook);

        public Task<object> UpdateUserBook(
            int id,
            UpdateBook updateMyBook);

        public Task<Book> GetSpecificBook(int id);
        public Task<List<Book>> GetAllBooks();
    }
}
