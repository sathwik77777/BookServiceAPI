using BookServiceAPI.Entities;
using BookServiceAPI.Database;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BookServiceAPI.Services
{
    public class BookService : IBookService
    {
        private readonly MyContext _context;

        public BookService()
        {
            _context = new MyContext();
        }
        public void AddBook(Book book)
        {
            try
            {

                _context.books.Add(book);
                _context.SaveChanges();

            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void DeleteBook(int bookId)
        {
            try
            {
                Book book = _context.books.SingleOrDefault(p => p.BookId == bookId);
                _context.books.Remove(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            try
            {
                List<Book> book = _context.books.Where(p => p.Author == author).ToList();
                return book;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void UpdateBook(Book book)
        {
            try
            {
                _context.books.Update(book);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                return _context.books.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Book> GetBooksByLang(string lang)
        {
            try
            {
                List<Book> book = _context.books.Where(p => p.Lang == lang).ToList();
                return book;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<Book> GetBooksByYear(int  year)
        {
            try
            {
                List<Book> book = _context.books.Where(p => p.Year == year).ToList();
                return book;
            }
            catch( Exception ex)
            {
                throw;
            }
        }




    }
}
