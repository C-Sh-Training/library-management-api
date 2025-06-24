using BookManagement.DbContext.Entities;
using BookManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult searchBookByTitle([FromQuery] string? title)
        {
            var foundBook = _bookService.searchBookByTitle(title);

            return Ok(foundBook);
        }

        [HttpPost]
        public IActionResult createBook([FromBody] Book newBook)
        {
            _bookService.createBook(newBook);

            return Ok("Added " + newBook.Title  + " list successfully");
        }

        [HttpPut]
        public IActionResult updateBook([FromQuery] int id, [FromBody] Book updateBook)
        {

            _bookService.updateBookById(id, updateBook);

            return Ok("Updated " + updateBook.Title + " successfully");
        }

        [HttpDelete]
        public IActionResult deleteBook([FromQuery] int id)
        {
            _bookService.deleteBookById(id);

            return Ok("Deleted successfully");
        }

    }
}
