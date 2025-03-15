using Microsoft.AspNetCore.Mvc;
using Models.Context;

namespace WebAppSchool.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _db = new SchoolContext();
        public IActionResult Index()
        {
            var list = _db.Students.ToList();
            return View(list);
        }
    }
}
