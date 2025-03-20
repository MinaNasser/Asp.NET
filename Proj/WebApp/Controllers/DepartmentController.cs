using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext db = new();
        public IActionResult Index()
        {
            List<Department> DepartmentList = 
                db.Department.Include(d=>d.Employees).ToList();
            return View("Index",DepartmentList);
        }
        public IActionResult Add()
        {
            return View("Add"); 
        }
        //[HttpGet]
        [HttpPost]  
        public IActionResult SaveAdd(Department departmentFromReq)
        {


            if (departmentFromReq.Name != null)
            {
                db.Department.Add(departmentFromReq);
                db.SaveChanges(); 
                //return View("Index" );
                //call action from anther Action 
                return RedirectToAction("Index");
            }
            return View("Add", departmentFromReq);
        }

        public IActionResult Edit(int id)
        {
            return View("Edit");
        }

    }
}
