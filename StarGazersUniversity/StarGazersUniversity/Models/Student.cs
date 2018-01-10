using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarGazersUniversity.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
        public string[] Classes { get; set; }
    }
}
