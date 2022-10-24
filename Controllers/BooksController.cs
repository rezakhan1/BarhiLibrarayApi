using BarhiLibrarayApi.Configuration;
using BarhiLibrarayApi.IBooksService;
using BarhiLibrarayApi.Moldel;
using BarhiLibrarayApi.RequestModel;
using BarhiLibrarayApi.Service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarhiLibrarayApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _booksService ;
      
        public BooksController(IBookService booksService,IDbConnection dbConnection)
        {
            _booksService = booksService;
             
        }
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var listOfBooks = new List<Book>();
            
            listOfBooks = _booksService.GetBooks();
           
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
        public IActionResult Post([FromBody] BookRequest book)
        {
            var addedBook = _booksService.AddBook(book);
            if (addedBook ==null)
            {
                return BadRequest("Incorrect Format");
            }

            return Ok(addedBook);
        }


        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] BookRequest bookRequest)
        {
            var updatedBook = _booksService.UpdateBook(id,bookRequest);
            if (updatedBook != null)
            {
                return NoContent();
            }
            return NotFound();

        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{bookId}")]
        public IActionResult Delete(string bookId)
        {
            var bookName = _booksService.DeleteBook(bookId);
            if(bookName == null)
            {
                return BadRequest("Failed to delete the book");
            }
            return Ok();
        }
    }
}
