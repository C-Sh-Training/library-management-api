using BookManagement.DbContext;
using BookManagement.Domains;
using BookManagement.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;

namespace BookManagement.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book createBook(Book newBook)
        {
            var checkBook = BookList.Books.Find(b => b.Id == newBook.Id);

            if(newBook.Id == checkBook?.Id)
            {
                throw new Exception("Duplicated ID!!!");
            }

            if(newBook == null)
            {
                throw new Exception("Invalid input!!!");
            }

            BookList.Books.Add(newBook);

            return newBook;
        }

        public bool deleteBookById(int? id)
        {

            if (id == null)
            {
                throw new Exception("ID can not be null");
            }

            var matchedBook = BookList.Books.Find(b => b.Id == id);

            if(matchedBook == null)
            {
                throw new Exception("Not found book to delete");
            }

            BookList.Books.Remove(matchedBook);

            return true;
        }

        public List<Book> GetAllBook()
        {
            return BookList.Books.Select(b => b).OrderBy(b => b.Id).ToList();
        }

        public List<Book> searchBookByTitle(string title)
        {

            var allBooks = BookList.Books.ToList();

            if (string.IsNullOrEmpty(title))
            {
                return allBooks;
            }

            var foundBook = allBooks.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundBook == null)
            {
                throw new Exception("There is no any book matched!");
            }

            return foundBook;
        }

        public Book updateBookById(int? id, Book book)
        {

            Book? bookToUpdate = null;

            if (id == null)
            {
                throw new Exception("ID can not be null");
            }

            if(book == null)
            {
                throw new Exception("Invalid input");
            }

            bookToUpdate = BookList.Books.FirstOrDefault(b => b.Id == id);

            if(bookToUpdate == null)
            {
                throw new Exception("Not found book to update");
            }

            bookToUpdate.Author = book.Author;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Title = book.Title;
            bookToUpdate.Year = book.Year;
            bookToUpdate.Genre = book.Genre;

            return bookToUpdate;
        }
    }
}
