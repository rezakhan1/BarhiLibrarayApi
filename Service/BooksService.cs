using BarhiLibrarayApi.Configuration;
using BarhiLibrarayApi.IBooksService;
using BarhiLibrarayApi.Moldel;
using BarhiLibrarayApi.RequestModel;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Text.Json;

namespace BarhiLibrarayApi.Service
{
    public class BooksService : IBookService
    {
        static private string filePath = @"./JsonDbFile/Books.json";
       
        private  string  conn;
        public BooksService(IDbConnection dbConnection)
        {
            
             conn = dbConnection.GetDbConnection();
        }
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
            
            var client = new MongoClient(conn);
            var database = client.GetDatabase("BarhiLibrary");

            var books = database.GetCollection<Book>("Books").AsQueryable().ToList();
         
            return books;
        }
        private List<Book> searchBookByBookName(string bookName)
        {
            var books = LoadBooks();
            var filtredBookbyBookName = books.FindAll(x => x.title.ToLower().Contains(bookName.ToLower()));
            return filtredBookbyBookName;
        }

        [Obsolete]
        public  string DeleteBook(string bookId)
        {
            
            var client = new MongoClient(conn);
            var database = client.GetDatabase("BarhiLibrary");

            var books = database.GetCollection<Book>("Books");
          
            var bookToBeDeleted = books.AsQueryable().ToList().FirstOrDefault(b => b.Id.Increment.ToString().Equals(bookId));  
          
            if (bookToBeDeleted != null)
            {
                books.DeleteOne(a=>a.Id== bookToBeDeleted.Id);
            }
            return "";
          
        }

        public Book UpdateBook(string bookId, BookRequest bookRequest)
        {
            var client = new MongoClient(conn);
            var database = client.GetDatabase("BarhiLibrary");

            var books = database.GetCollection<Book>("Books");
            var bookToBeDeleted = books.AsQueryable().ToList().FirstOrDefault(b => b.Id.Increment.ToString().Equals(bookId));
            if (bookToBeDeleted!=null)
            {
                bookToBeDeleted.title = bookRequest.Title;
                bookToBeDeleted.pages = bookRequest.Pages;
                bookToBeDeleted.author = bookRequest.Author;
                bookToBeDeleted.categories = bookRequest.Categories;
                books.DeleteOne(a => a.Id == bookToBeDeleted.Id);
                books.InsertOne(bookToBeDeleted);
            }
          

            return bookToBeDeleted;

        }

        public Book AddBook(BookRequest book)
        {
            var client = new MongoClient(conn);
            var database = client.GetDatabase("BarhiLibrary");

            var books = database.GetCollection<Book>("Books");
            var addBook = new Book()
            {
                title = book.Title,
                pages = book.Pages,
                filesize = book.Filesize,
                author = book.Author,
                categories = book.Categories,

            };
            // Update json data string
            books.InsertOne(addBook);
           

            return addBook;
        }
    }
}
