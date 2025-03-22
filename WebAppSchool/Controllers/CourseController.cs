using Microsoft.AspNetCore.Mvc;
using Models.Context;

namespace WebAppSchool.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext context = new SchoolContext();
        public IActionResult Index()
        {
            var list = context.Courses.ToList();    
            return View(list);
        }
    }
}
