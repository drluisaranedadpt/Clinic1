using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDPT.Entities
{
    public class HomeAddress
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Address1 { get; set; }
        [StringLength(250)]
        public string Address2 { get; set; }
        [StringLength(250)]
        public string Apt { get; set; }
        [StringLength(250)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Zip { get; set; }

        public HomeAddress()
        {

        }
    }
}
