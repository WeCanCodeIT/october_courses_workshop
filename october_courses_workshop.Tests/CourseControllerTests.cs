using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using october_courses_workshop.Models;
using october_courses_workshop.Controllers;
using Microsoft.AspNetCore.Mvc;
using october_courses_workshop.Repositories;

namespace october_courses_workshop.Tests
{
    public class CourseControllerTests
    {

        CourseController underTest = new CourseController(CoursesRepository);

        public static IRepository<Courses> CoursesRepository { get; private set; }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_CourseModel_To_View()
        {
            var result = underTest.Index();

            Assert.IsType<List<Courses>>(result.Model);
        }




    }
}
