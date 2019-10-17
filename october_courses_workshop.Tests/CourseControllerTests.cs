using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using october_courses_workshop.Models;
using october_courses_workshop.Controllers;
using Microsoft.AspNetCore.Mvc;
using october_courses_workshop.Repositories;
using NSubstitute;

namespace october_courses_workshop.Tests
{
    public class CourseControllerTests
    {

        CourseController underTest;
        IRepository<Courses> coursesRepo;

        public CourseControllerTests()
        {
            coursesRepo = Substitute.For<IRepository<Courses>>();
            underTest = new CourseController(coursesRepo);
        }

       

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedCourses = new List<Courses>();
            coursesRepo.GetAll().Returns(expectedCourses);

            var result = underTest.Index();

            Assert.Equal(expectedCourses, result.Model);
        }

        [Fact]
        public void Details_Return_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_All_Course_To_View()
        {
            var expectedCourses = new Courses();
            coursesRepo.GetById(1).Returns(expectedCourses);

            var result = underTest.Details(1);

            Assert.Equal(expectedCourses, result.Model);
        }


    }
}
