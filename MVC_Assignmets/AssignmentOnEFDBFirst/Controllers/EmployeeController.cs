using HandsOnEFDBFirst.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDBFirst.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDb1Context myDb1Context;
        public EmployeeController()
        {
            myDb1Context = new MyDb1Context();
        }
        public IActionResult Index()
        {
            var employees= myDb1Context.EmDetails.ToList();
            return View(employees);
        }

        public IActionResult Details(int EmployeeId)
        {
            var employee= myDb1Context.EmDetails.SingleOrDefault(e=>e.EmpId==EmployeeId);
            return View(employee);
        }
    }
}
