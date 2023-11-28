using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDPT.Entities
{
    public class Physician 
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string City { get; set; }
        [StringLength(250)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

        public Physician()
        {

        }
    }
}
