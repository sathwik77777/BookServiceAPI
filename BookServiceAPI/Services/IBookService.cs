using BookServiceAPI.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BookServiceAPI.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks(); //done
        void AddBook(Book book);//done
        List<Book> GetBooksByAuthor(string author); //done
        List<Book> GetBooksByLang(string lang); //Done
        List<Book> GetBooksByYear(int year); //done
        void UpdateBook(Book book); //done
        void DeleteBook(int bookId); //done
    }
}
