using BarhiLibrarayApi.Moldel;

namespace BarhiLibrarayApi.IBooksService
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public List<Book> GetBookByBookName(string bookname);
    }
}
