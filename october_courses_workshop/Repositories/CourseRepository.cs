using october_courses_workshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using october_courses_workshop.Data;

namespace october_courses_workshop.Repositories
{
    public class CourseRepository : IRepository<Courses>
    {
        private UniversityContext db;

        public CourseRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(Courses course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
        }

        public void Delete(Courses course)
        {
            db.Courses.Remove(course);
            db.SaveChanges();
        }

        public IEnumerable<Courses> GetAll()
        {
            return db.Courses;
        }

        public Courses GetById(int id)
        {
            return db.Courses.Single(c => c.Id == id);
        }
    }
}
