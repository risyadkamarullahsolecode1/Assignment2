using Assignment2.Interface;
using Assignment2.Models;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2.Services
{
    public class BookServices:IBookService
    {
        private List<Book> books;
        public BookServices()
        { 
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void UpdateBook(Book book)
        {
            var bukuOld = GetbookbyId(book.Id);
            if (bukuOld == null)
            {
                throw new Exception("Buku tidak ada");
            }
            var Index = books.IndexOf(book);
            books[Index] = book;
        }
        public List<Book> GetAllBook()
        {
            return books;
        }
        public int GetbookbyId(int id)
        {
            var book = books[id];
            if (book == null)
            {
                throw new Exception($"book dengan Id {id} tidak ada");
            }
            return book.Id;
        }
        
        public void DeleteBookByID(int id)
        {
            var book = books.FirstOrDefault(book => book.Id == id);
            books.Remove(book);
        }
    }
}
