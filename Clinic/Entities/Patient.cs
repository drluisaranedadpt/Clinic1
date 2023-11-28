using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDPT.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string MiddleInitial { get; set; }
        [StringLength(50)]
        public string Age { get; set; }
        [StringLength(50)]
        public string Gender { get; set; }
        [StringLength(50)]
        public string CDL { get; set; }

        public Patient()
        {

        }
    }
}
