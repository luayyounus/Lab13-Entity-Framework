using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarGazersUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
        public string ClassOne { get; set; }
        public string ClassTwo { get; set; }
    }
}
