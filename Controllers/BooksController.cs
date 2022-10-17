using BarhiLibrarayApi.IBooksService;
using BarhiLibrarayApi.Moldel;
using BarhiLibrarayApi.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarhiLibrarayApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _booksService ;
        public BooksController(IBookService booksService)
        {
            _booksService = booksService;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var listOfBooks = _booksService.GetBooks();
            return listOfBooks;
        }

        // GET api/<BooksController>/5
        [HttpGet("{bookname}")]
        public IEnumerable<Book> Get(string bookname)
        {
            var listOfBooks = _booksService.GetBookByBookName(bookname);
            return listOfBooks;
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
