using Microsoft.AspNetCore.Mvc;
using october_courses_workshop.Models;
using october_courses_workshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace october_courses_workshop.Controllers
{
    public class InstructorController : Controller
    {

        IRepository<Models.Instructor> instructorRepo;

        public InstructorController(IRepository<Instructor> instructorRepo)
        {
            this.instructorRepo = instructorRepo;
        }

        public ViewResult Index()
        {
            var model = instructorRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = instructorRepo.GetById(id);
            return View(model);
        }
    }
}
