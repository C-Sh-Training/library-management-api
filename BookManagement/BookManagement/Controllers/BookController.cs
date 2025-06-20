using BookManagement.Domains;
using BookManagement.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("get-all")]
        public IActionResult getAllBook() 
        {
            var allBook = _bookRepository.GetAllBook();

            if (allBook == null) 
            { 
                return NotFound("Not found any book");
            }

            return Ok(allBook);
        }

        [HttpGet("search-book")]
        public IActionResult searchBookByTitle([FromQuery] string title)
        {
            var foundBook = _bookRepository.searchBookByTitle(title);

            return Ok(foundBook);
        }

        [HttpPost("create-book")]
        public IActionResult createBook([FromBody] Book newBook)
        {
            _bookRepository.createBook(newBook);

            return Ok("Added " + newBook.Title  + " list successfully");
        }

        [HttpPut("update-book")]
        public IActionResult updateBook([FromQuery] int id, [FromBody] Book updateBook)
        {

            _bookRepository.updateBookById(id, updateBook);

            return Ok("Updated " + updateBook.Title + " successfully");
        }

        [HttpDelete("delete-book")]
        public IActionResult deleteBook([FromQuery] int id)
        {
            _bookRepository.deleteBookById(id);

            return Ok("Deleted successfully");
        }

    }
}
