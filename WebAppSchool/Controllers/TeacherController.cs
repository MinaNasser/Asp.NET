using Microsoft.AspNetCore.Mvc;
using Models.Context;

namespace WebAppSchool.Controllers
{
    public class TeacherController : Controller
    {
        private SchoolContext _db = new SchoolContext();
        public IActionResult Index()
        {
            var list = _db.Teatchers.ToList();
            return View(list);
        }
    }
}
