using System;
using Xunit;
using october_courses_workshop.Models;
using System.Text;

namespace october_courses_workshop.Tests
{
    public class CoursesTests
    {
        Courses underTest;

        public CoursesTests()
        {
            underTest = new Courses(42, "Course Name", "Description of course");
        }

        [Fact]
        public void CourseConstructor_Sets_Name_On_CourseModel()
        {
            var result = underTest.Name;

            Assert.Equal("Course Name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Id_On_CourseModel()
        {
            var result = underTest.Id;

            Assert.Equal(42, result);
        }

        [Fact]
        public void CourseConstructor_Sets_Description_On_CourseModel()
        {
            var result = underTest.Description;

            Assert.Equal("Description of course", result);
        }

    }
}
