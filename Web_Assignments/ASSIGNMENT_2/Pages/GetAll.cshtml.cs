using HandsOnModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandsOnModel.Pages
{
    public class GetAllModel : PageModel
    {
       static  List<Product> products = new List<Product>()
        {
            new Product(){id=1,name="mouse",price=100,stock=10},
            new Product(){id=2,name="keyboard",price=200,stock=20},
            new Product(){id=3,name="pendrive",price = 200,stock=20}
        };

        [BindProperty]
        public Product P { get; set; }
        public List<Product> List
        {
            get { return products; }
        }
        public IActionResult  OnPost()
        {
            products.Add(P);
            return RedirectToPage("GetAll");
        }
    }
}
