using BookManagement.DbContext.Entities;

namespace BookManagement.Services
{
    public interface IBookService
    {

        List<Book> searchBookByTitle(string? title);

        Book createBook(Book book);

        Book updateBookById(int? id, Book book);

        bool deleteBookById(int? id);
    }
}
