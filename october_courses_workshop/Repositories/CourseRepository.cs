using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using october_courses_workshop.Models;

namespace october_courses_workshop.Repositories
{
    public class CourseRepository: IRepository<Courses>
    {
        public List<Courses> coursesList;

        public CourseRepository()
        {
            coursesList = new List<Courses>()
            {
                new Courses(1, "Machine Learning", "Machine learning for humans"),
                new Courses(2, "C# for Smarties", "It's all you need to learn it all"),
                new Courses(3, "HTML, CSS, JS, oh my!", "OMG, the front end will become your BFF")
            };

        }

        public IEnumerable<Courses> GetAll()
        {
            return coursesList;
        }

        public Courses GetById(int id)
        {
            return coursesList.Single(c => c.Id == id);
        }

    }
}
