using Assignment2.Models;

namespace Assignment2.Interface
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBook();
        int GetbookbyId(int id);
        void UpdateBook(Book book);
        void DeleteBookByID(int id);
    }
}
