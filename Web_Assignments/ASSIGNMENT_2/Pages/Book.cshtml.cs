using HandsOnModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandsOnModel.Pages
{
    public class BookModel : PageModel
    {
        static List<BookList> Books = new List<BookList>
        {
            new BookList(){Id=1,Name="book1",Price=200,Language="English",Author="RAM"},
            new BookList(){Id=2,Name="book2",Price=100,Language="Telugu",Author="Raju"},

            new BookList(){Id=3,Name="book3",Price=360,Language="Hindi",Author="Priya"}


        };

        [BindProperty ]
        public BookList B { get; set; }

        public List<BookList> List1
        {
            get { return Books; }
        }


        public IActionResult OnPost()
        {
            Books.Add(B);

            return RedirectToPage(Books);
        }
    }
}