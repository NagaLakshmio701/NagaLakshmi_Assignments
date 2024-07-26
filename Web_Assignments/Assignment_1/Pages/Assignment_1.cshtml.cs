using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_1.Pages
{
    public class Assignment_1Model : PageModel
    {
        [BindProperty]

        public string Name {  get; set; }

        [BindProperty]

        public string   Password { get; set; }

        public string Message { get; set; }
        public void Onpost()
        {
            if (Password == "anushka")
            {
                Message = "LOGIN IS SUCCESS";
            }

            else
            {
                Message = "LOGIN IS NOT SUCCESS";
            }
        }
    }
}
