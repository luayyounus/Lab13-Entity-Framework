using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarGazersUniversity.Data;
using StarGazersUniversity.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarGazersUniversity.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly StudentDbContext _context;
        public EnrollmentController(StudentDbContext context)
        {
            _context = context;
        }

        // Release the allocated resources for Student Context
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IActionResult ViewAllStudents()
        {
            List<Student> students = _context.Students.ToList();
            return View(students);
        }
    }
}
