using Microsoft.AspNetCore.Mvc;
using Models.Context;
using Models.Entities;

namespace WebAppSchool.Controllers
{
    public class TeacherController : Controller
    {
        private SchoolContext _db = new SchoolContext();
        public IActionResult List()
        {
            var list = _db.Teatchers.ToList();
            return View("Index",list);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Teacher teacher)
        {
            _db.Teatchers.Add(teacher);
            _db.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var selected = _db.Teatchers.FirstOrDefault(i => i.TeacherId == Id);
            return View(selected);
        }

        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            _db.Teatchers.Update(teacher);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var teacher = _db.Teatchers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _db.Teatchers.Remove(teacher);
            _db.SaveChanges();

            return RedirectToAction("List");
        }


    }
}
