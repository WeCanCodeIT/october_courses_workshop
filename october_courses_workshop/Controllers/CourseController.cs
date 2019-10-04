using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using october_courses_workshop.Models;
using october_courses_workshop.Repositories;


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
            //CourseRepository courseRepo = new CourseRepository();

            var model = courseRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = courseRepo.GetById(id);
            return View(model);
        }
    }
}
