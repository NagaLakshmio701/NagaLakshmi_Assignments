using HandsOnEFDBFirst.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDBFirst.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly MyDb1Context myDb1Context;
        public DepartmentController()
        {
            myDb1Context = new MyDb1Context();
        }

        public IActionResult Index()
        {
            var employees = myDb1Context.Departments.ToList();
            return View(employees);
        }

        public IActionResult Details(string deptId)
        {
            var employee = myDb1Context.Departments.SingleOrDefault(e => e.DeptCode == deptId);
            return View(employee);
        }
    }
}
