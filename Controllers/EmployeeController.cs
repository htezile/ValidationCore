using Microsoft.AspNetCore.Mvc;
using ValidationCore.Models;

namespace ValidationCore.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> allEmployees = new List<Employee>();
        public IActionResult AllEmployee()
        {
            return View(allEmployees);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                allEmployees.Add(employee);
                return RedirectToAction("AllEmployee");
            }

            return View();
        }
    }
}
