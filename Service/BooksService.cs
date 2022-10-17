using BarhiLibrarayApi.IBooksService;
using BarhiLibrarayApi.Moldel;
using System.Text.Json;

namespace BarhiLibrarayApi.Service
{
    public class BooksService : IBookService
    {
        public List<Book> GetBooks()
        {
            List<Book> books = LoadBooks();
            return books;
        }

        public List<Book> GetBookByBookName(string bookName)
        {
            List<Book> books = searchBookByBookName(bookName);
            return books;
        }

        private List<Book> LoadBooks()
        {
            using (StreamReader r = new StreamReader(@"./JsonDbFile/Books.json"))
            {
                string json = r.ReadToEnd();
                List<Book> items = JsonSerializer.Deserialize<List<Book>>(json);
                return items;
            } 
        }
        private List<Book> searchBookByBookName(string bookName)
        {
            using (StreamReader r = new StreamReader(@"./JsonDbFile/Books.json"))
            {
                string json = r.ReadToEnd();
                List<Book> items = JsonSerializer.Deserialize<List<Book>>(json);
                var filtredBookbyBookName = items.FindAll(x => x.title.ToLower().Contains(bookName.ToLower()));
                return filtredBookbyBookName;
            }
        }
    }
}
