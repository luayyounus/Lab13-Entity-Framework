using System;
using Xunit;
using StarGazersUniversity.Controllers;
using StarGazersUniversity.Data;
using Microsoft.EntityFrameworkCore;
using StarGazersUniversity.Models;
using System.Linq;

namespace XUnitTestStarGazers
{
    public class HomeControllerTest
    {
        private StudentDbContext _context;

        public HomeControllerTest()
        {
            DbContextOptionsBuilder<StudentDbContext> builder = new DbContextOptionsBuilder<StudentDbContext>();
            builder.UseInMemoryDatabase();
            DbContextOptions<StudentDbContext> options = builder.Options;
            _context = new StudentDbContext(options);
        }

        [Fact]
        public void Add_New_Student_To_Context()
        {
            Student student = new Student() { FirstName = "Micky", LastName = "Minnie", Class = "Singing" };

            _context.Students.Add(student);
            _context.SaveChanges();

            Student foundEntity = _context.Students.FirstOrDefault(x => x.FirstName == student.FirstName);

            Assert.NotNull(foundEntity);
        }
    }
}