using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
{
    public class studentController : Controller
    {
        private readonly DataBasedbContext _context;
        public studentController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Addstudents()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addstudents(StudentsModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "student");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Display()
        {
            var res = from s in _context.STUDENTS

                      where s.StudentName != "Brijesh"
                      select s;
            
            var res2 = _context.STUDENTS.Where(a => a.StudentName.StartsWith("p"));
            var res3 = from s in _context.STUDENTS where s.StudentName.StartsWith("B")&& s.StudentAddress =="nellore" 
                 select s;
            var res4 = from s in _context.STUDENTS orderby s.StudentName descending  select s;
        


            return View(res4.ToList());
           // return View(_context.STUDENTS.ToList());
        }
        [HttpGet]
        public IActionResult update(int? StudentID)
        {
            if (StudentID == null)
            {
                return NotFound();
            }
            var data = _context.STUDENTS.Find(StudentID);
            return View(data);
        }
        [HttpPost]
        public IActionResult update(int StudentID, StudentsModel obj)
        {
            if (ModelState.IsValid)
            {
                _context.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "student");
            }
            return View();
        }
        public IActionResult Delete(int? StudentID)
        {
            var result = _context.STUDENTS.Find(StudentID);
            if (result != null)
            {
                _context.STUDENTS.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "student");
            }
            return View();
        }
    }
}
