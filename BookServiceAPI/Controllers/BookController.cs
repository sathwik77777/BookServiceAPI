using BookServiceAPI.Entities;
using BookServiceAPI.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookService bookService;

        public BookController()
        {
            bookService = new BookService();
        }

        [HttpGet,Route("GetAllBook")]
        public IActionResult GetAll()
        {
            try
            {
                List<Book> book = bookService.GetAllBooks();
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
              
        }

        [HttpPost,Route("AddBooks")]
        public IActionResult Add([FromBody] Book book)
        {
            try
            {
                bookService.AddBook(book);
                return StatusCode(200, book);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut,Route("EditBooks")]
        public IActionResult Update(Book book) 
        {
            try
            {
                bookService.UpdateBook(book);
                return StatusCode(200, book);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete,Route("DeleteBook/{BookId}")]
        public IActionResult Delete( int bookId)
        {
            try
            {
                bookService.DeleteBook(bookId);
                return StatusCode(200, new JsonResult($"Book with Id {bookId} is Deleted"));
            }
            catch(Exception ex )
            {
                return StatusCode(500, ex.Message);

            }
            
        }

        [HttpGet,Route("GetBookByAuthor")]
        public IActionResult GBBA(string author)
        {
            try
            {
                List<Book> book = bookService.GetBooksByAuthor(author);
                if(book !=null)
                    return StatusCode(200, book);
                else
                    return StatusCode(404,new JsonResult("Invalid Author"));


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetBookByLanguage")]
        public IActionResult GBBL(string lang)
        {
            try
            {
                List<Book> book = bookService.GetBooksByLang(lang);
                if (book != null)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Invalid Language"));


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetBookByYear")]
        public IActionResult GBBY(int year)
        {
            try
            {
                List<Book> book = bookService.GetBooksByYear(year);
                if (book != null)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Invalid Year"));


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }




    }
}
