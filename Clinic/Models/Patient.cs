using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string CDL { get; set; }
        public string SSN { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Unstated { get; set; }
        public string Male { get; set; }
        public string Female { get; set; }
        public int Age { get; internal set; }

        public Patient()
        {

        }
    }
}
