using BookManagement.DbContext.Entities;
using BookManagement.Repositories;

namespace BookManagement.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book createBook(Book book)
        {
            _bookRepository.createBook(book);
            return book;
        }

        public bool deleteBookById(int? id)
        {
            _bookRepository.deleteBookById(id);
            return true;
        }

        public List<Book> searchBookByTitle(string? title)
        {
            return _bookRepository.searchBookByTitle(title); 
        }

        public Book updateBookById(int? id, Book book)
        {
            return _bookRepository.updateBookById(id, book);
        }
    }
}
