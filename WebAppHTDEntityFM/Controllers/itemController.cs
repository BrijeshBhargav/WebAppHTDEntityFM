using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;


namespace WebAppHTDEntityFM.Controllers
{
    public class itemController : Controller
    {
        private readonly DataBasedbContext _context;
        public itemController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Additems()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Additems(ItemsModel obj)
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
