using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebAppHTDEntityFM.Controllers
{
    public class EmpOneToManyController : Controller
    {
        private readonly DataBasedbContext _context;
        public EmpOneToManyController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddEmp()
        {
            ViewBag.Bank = new SelectList(_context.Bank, "BankID","BankName");
                return View();
        }
        [HttpPost]
        public IActionResult AddEmp(Employee obj)
        {
            _context.employee1.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("AddEmp");
        }
        [HttpGet]
        public IActionResult GetEmp()
        {
        //    var res = _context.employee1.ToList();
            var res1 = (from s in _context.employee1 select s).Include(x => x.Bank).ToList();
            return View(res1);
        }
    }
}
