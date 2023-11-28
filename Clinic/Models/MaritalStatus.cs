using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class MaritalStatus
    {
        public int Id { get; set; }
        public string Single { get; set; }
        public string Married { get; set; }
        public string Separated { get; set; }
        public string Widowed { get; set; }
        public MaritalStatus()
        {

        }
    }
}
