using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarGazersUniversity.Data;
using StarGazersUniversity.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarGazersUniversity.Controllers
{
    public class HomeController : Controller
    {
        // Bringing the context to this controller.
        private readonly StudentDbContext _context;
        public HomeController(StudentDbContext context)
        {
            _context = context;
        }

        // Release the allocated resources for Student Context
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (!String.IsNullOrEmpty(student.FirstName))
            {
                _context.Add(student);
                _context.SaveChanges();
            }
            
            return RedirectToAction("ViewAllStudents", "Enrollment");
        }
    }
}
