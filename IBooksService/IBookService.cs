using BarhiLibrarayApi.Moldel;
using BarhiLibrarayApi.RequestModel;

namespace BarhiLibrarayApi.IBooksService
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public List<Book> GetBookByBookName(string bookname);

        public string DeleteBook(string bookId);

        public Book UpdateBook(string bookId, BookRequest book);

        public Book AddBook(BookRequest book);
    }
}
