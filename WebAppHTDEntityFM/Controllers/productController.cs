using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WebAppHTDEntityFM.Models;
namespace WebAppHTDEntityFM.Controllers
{
    public class productController : Controller
    {
        private readonly DataBasedbContext _context;
        public productController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Addproducts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addproducts(ProductsModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display","product");

            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            //var res = from s in _context.PRODUCTSS

            //          where s.PRICE > 30000 && s.PRICE < 70000
            //         select s;

          // var res = from s in _context.PRODUCTSS where (s.PNAME .Contains("Mobile")) select s;

           
           // return View(res.ToList());

            return View(_context.PRODUCTSS.ToList());
        }
        [HttpGet]
        public IActionResult update(int? PID)
        {
            if (PID == null)
            {
                return NotFound();
            }
            var data = _context.PRODUCTSS.Find(PID);
            return View(data);
        }
        [HttpPost]
        public IActionResult update(int PID, ProductsModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "product");
            }
            return View();
        }
        public IActionResult Delete(int? PID)
        {
            var result=_context.PRODUCTSS.Find(PID);
            if (result != null)
            {
                _context.PRODUCTSS.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "product");
            }
            return View();
        }
    }
}
