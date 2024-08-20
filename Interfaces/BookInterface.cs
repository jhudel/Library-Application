using TechExam.Models;

namespace TechExam.Interfaces
{
    public interface BookInterface
    {
        public Task AddNewBook(AddNewBook myNewBook);
        //public Task<object> UpdateUserBook(
        //    int id,
        //    string title,
        //    string author,
        //    string isbn,
        //    DateTime? publishedDate);


        public Task<object> UpdateUserBook(
            int id,
            UpdateBook updateMyBook);

        public Task<AddNewBook> GetSpecificBook(int id);
        public Task<List<AddNewBook>> GetAllBooks();
    }
}
