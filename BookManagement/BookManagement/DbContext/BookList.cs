using BookManagement.Entities;

namespace BookManagement.DbContext
{
    public class BookList
    {
        public static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Title = "C# in Depth", Author = "lsdkfjl", Description = " fsdkjfldsjhaflj", Year = 2019,  Genre = "French" },
            new Book { Id = 2, Title = "Clean code", Author = "lsdkfjl", Description = " fsdkjfldsjhaflj", Year = 1988,  Genre = "Germany" },
            new Book { Id = 3, Title = "Java", Author = "Cox", Description = " fsdkjfldsjhaflj", Year = 2002,  Genre = "Indonesia" },
        };
    }
}
