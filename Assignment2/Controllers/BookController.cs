using Assignment2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Services;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookServices _bookServices;
        public BookController(BookServices bookServices)
        {
            _bookServices = bookServices;
        }
        //Add Book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _bookServices.AddBook(book);
            if (book == null)
            {
                return BadRequest();
            }
            return Ok($"Buku ditambahkan pada halaman {book}");
        }

        // Get All Books
        [HttpGet("GetAllBook")]
        public IActionResult GetAllBook()
        {
            var book = _bookServices.GetAllBook();
            return Ok(book);
        }

        // Get Book by Id
        [HttpGet("GetbookbyId/{id}")]
        public IActionResult GetbookbyId(int id) 
        { 
            var book = _bookServices.GetbookbyId(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        //Update
        [HttpPut("UpdateBooks")]
        public IActionResult UpdateBook(Book book) 
        { 
            _bookServices.UpdateBook(book);
            return Ok("Buku telah di update");
        }

        // Delete
        [HttpDelete("DeleteBook/{id}")]
        public ActionResult DeleteBookByID(int id)
        {
            _bookServices.DeleteBookByID(id);
            if(id == 0)
            {
                return BadRequest(id);
            }
            return Ok($"Buku dengan {id} telah dihapus");
        }
    }
}
