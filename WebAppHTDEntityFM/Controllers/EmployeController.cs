using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
{
    public class EmployeController : Controller
    {
        private readonly DataBasedbContext _context;
        public EmployeController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddEmpdetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmpdetails(EmployeeModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "product");
            }
            return View(obj);
        }
    }
}
