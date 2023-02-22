using Microsoft.AspNetCore.Mvc;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
{
    public class EmpAddController : Controller
    {
        private readonly DataBasedbContext _context;
        public EmpAddController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(EmployeAddModel obj)
        {
            EmpModel objEmployee = new EmpModel();
            objEmployee.EMPNAME = obj.EMPNAME;
            _context.Employeee.Add(objEmployee);
            _context.SaveChanges();

            EmpAddressModel objAdress = new EmpAddressModel();
            objAdress.EMPADDRESS=obj.EMPADDRESS;
            objAdress.EMPID= objEmployee.EMPID;
            _context.EmpAdd.Add(objAdress);
            _context.SaveChanges();

            return View();
        }
    }
}
