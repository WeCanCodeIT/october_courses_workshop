using october_courses_workshop.Models;
using october_courses_workshop.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace october_courses_workshop.Controllers
{
    public class CourseController : Controller
    {
        IRepository<Courses> courseRepo;

        public CourseController(IRepository<Courses> courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        public ViewResult Index()
        {
            var model = courseRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = courseRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Courses course)
        {
            courseRepo.Create(course);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult CreateByInstructorId(int id)
        {
            ViewBag.InstructorId = id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = courseRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Courses course)
        {
            courseRepo.Delete(course);
            return RedirectToAction("Index");
        }
    }
}
