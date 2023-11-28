using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class WorkStatus
    {
        public int Id { get; set; }
        public string Employed { get; set; }
        public string Unemployed { get; set; }
        public string PartTimeStudent { get; set; }
        public string FullTimeStudent { get; set; }
        public string Disabled { get; set; }
        public string Retired { get; set; }
        public WorkStatus()
        {

        }
    }
}
