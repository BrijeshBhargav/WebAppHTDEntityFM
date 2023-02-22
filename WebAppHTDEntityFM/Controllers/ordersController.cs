using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
{
    public class ordersController : Controller
    {
       
            private readonly DataBasedbContext _context;
            public ordersController(DataBasedbContext context)
            {
                _context = context;
            }
            [HttpGet]
            public IActionResult Addorders()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Addorders(OrdersModel obj)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(obj);
                    _context.SaveChanges();
                    return RedirectToAction("Display", "orders");
                }
                return View(obj);
            }
        [HttpGet]
        public IActionResult Display()
        {
            var res= from s in _context.Orderss orderby s.ORDERID ascending  select s;
            return View(res.ToList());
            //return View(_context.Orderss.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int? ORDERID)
        {
            if (ORDERID == null)
            {
                return NotFound();
            }
            var data = _context.Orderss.Find(ORDERID);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(int ORDERID, OrdersModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "orders");
            }
            return View();
        }
        public IActionResult Delete(int? ORDERID)
        {
            var result = _context.Orderss.Find(ORDERID);
            if (result != null)
            {
                _context.Orderss.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "orders");
            }
            return View();
        }
    }
}
    

