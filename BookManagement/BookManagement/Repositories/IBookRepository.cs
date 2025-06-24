using BookManagement.DbContext.Entities;

namespace BookManagement.Repositories
{
    public interface IBookRepository
    {

        List<Book> searchBookByTitle(string? title);

        Book createBook(Book book);

        Book updateBookById(int? id, Book book);

        bool deleteBookById(int? id);
    }
}
