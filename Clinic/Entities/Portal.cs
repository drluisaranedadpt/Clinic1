using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicDPT.Entities
{
    public class Portal 
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Address1 { get; set; }
        [StringLength(250)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string ZipCode { get; set; }
        [StringLength(50)]
        public string Title { get; set; }



        public Portal()
        {

        }
    }
}
