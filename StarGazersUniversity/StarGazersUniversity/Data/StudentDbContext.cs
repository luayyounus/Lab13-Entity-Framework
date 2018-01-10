using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarGazersUniversity.Models;

namespace StarGazersUniversity.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Student { get; set; }
    }
}
