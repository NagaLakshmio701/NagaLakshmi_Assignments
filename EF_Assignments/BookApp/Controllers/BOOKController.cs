using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BookApp.Entities;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace BookApp.Controllers
{
    public class BOOKController : Controller
    {
        private readonly BookAppContext bookAppContext;

        public BOOKController()
        {
            bookAppContext = new BookAppContext();
        }

        //GETALLBOOKS
        public IActionResult GetAllBooks()
        {
            var books = bookAppContext.Books;
            return View(books);
        }

        //ADD BOOK

        [HttpGet]
        [Route("Add/{BookID}")]

        public IActionResult AddBook(int BookID)
        {
            return View();
        }
        [HttpPost]

        [Route("Add")]

        public IActionResult AddBook(Book book)
        {

            if (ModelState.IsValid)
            {
               bookAppContext.Books.Add(book);
               bookAppContext.SaveChanges();
               return RedirectToAction("GetAllBooks");
            }
            else
            {
                return View();
            }
        }

        //DETAILS

        public IActionResult Details(int BookID)
        {
          
            var book = bookAppContext.Books.Where(b => b.BookId == BookID).ToList();

            return View(book);

        }

        // GET BOOKS BY AUTHOR


        [Route("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            var book = bookAppContext.Books.Where(b => b.Author == author).ToList();

            return View(book);

        }
        // GET BOOKS BY LANGUAGE


        [Route("GetBookByLang/{lang}")]
        public IActionResult GetBookByLang(string lang)
        {
            var book = (from e in bookAppContext.Books
                        where e.Lang ==lang
                        select e).ToList();
            return View(book);

        }


        // GET BOOKS BY YEAR

        [Route("GetBookByYear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
           /* var book = (from e in bookAppContext.Books
                        where e.ReleaseDate.Value.Year== year
                        select e).ToList();*/

            var book= bookAppContext.Books.Where(b=>b.ReleaseDate.Value.Year== year).ToList();
            return View(book);

        }

        //EDIT BOOK

        [HttpGet]
        [Route("Edit/{BookID}")]


        public IActionResult EditBook(int BookID)
        {
          
            var book=bookAppContext.Books.SingleOrDefault(b=>b.BookId == BookID);
            return View(book);
                     
        }

        [HttpPost]
        [Route("Edit/{BookID}")]

        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                bookAppContext.Books.Update(book);
                bookAppContext.SaveChanges();
                return RedirectToAction("GetAllBooks");
            }
            return View(book);
        }


        //DELETE BOOK

        [HttpGet]
/*        [Route("delete/{BookID}")]
*/

        public IActionResult DeleteBook(int BookID)
        {

            var book = bookAppContext.Books.SingleOrDefault(b => b.BookId == BookID);
            return View(book);

        }

        [HttpPost]
/*        [Route("delete")]
*/
        public IActionResult DeleteBook(Book book)
        {
          
                bookAppContext.Books.Remove(book);
                bookAppContext.SaveChanges();
                return RedirectToAction("GetAllBooks");
            
            
        }

    }
       
    }

