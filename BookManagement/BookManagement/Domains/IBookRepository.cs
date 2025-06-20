using BookManagement.Entities;

namespace BookManagement.Domains
{
    public interface IBookRepository
    {
        public List<Book> GetAllBook();

        List<Book> searchBookByTitle(string title);

        Book createBook(Book book);

        Book updateBookById(int? id, Book book);

        bool deleteBookById(int? id);
    }
}
