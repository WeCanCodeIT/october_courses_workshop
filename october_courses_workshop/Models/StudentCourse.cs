using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace october_courses_workshop.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int CourseId { get; set; }
        public virtual Courses Course { get; set; }
    }
}
