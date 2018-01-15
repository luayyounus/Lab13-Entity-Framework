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
        public IActionResult ViewAllStudents(string sortType)
        {

            List<Student> students = _context.Students.ToList();

            if (!String.IsNullOrEmpty(sortType))
            {
                switch (sortType)
                {
                    case "FN":
                        students = students.OrderBy(s => s.FirstName).ToList();
                        break;
                    case "LN":
                        students = students.OrderBy(s => s.LastName).ToList();
                        break;
                }
            }

            return View(students);
        }

        [HttpGet]
        public IActionResult FilteredStudentsByName(string studentName)
        {
            List<Student> students = new List<Student>();
            if (!(String.IsNullOrEmpty(studentName)))
            {
                // Filtering students based on Student name
                students = _context.Students.Where(s => s.FirstName.ToLower() == studentName.ToLower())
                                                          .ToList();
                return View(students);
            }
            return View(students);
        }

        [HttpPost]
        public IActionResult FilterStudentsByName(string studentName)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("ViewAllStudents");

            return RedirectToAction("FilteredStudentsByName", new { studentName });
        }

        [HttpGet]
        public IActionResult FilteredStudentsByClass(string className)
        {
            List<Student> students = new List<Student>();
            if (!(String.IsNullOrEmpty(className)))
            {
                // Filtering students based on Class name
                students = _context.Students.Where(s => s.Class.ToLower() == className.ToLower())
                                                          .ToList();
                return View(students);
            }

            return View(students);
        }

        [HttpPost]
        public IActionResult FilterStudentsByClass(string className)
        {
            // Check if user input is valid
            if (!ModelState.IsValid)
                return RedirectToAction("ViewAllStudents");

            return RedirectToAction("FilteredStudentsByClass", new { className });
        }
    }
}
