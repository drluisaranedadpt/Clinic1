using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string InsuranceName { get; set; }
        public string PolicyNumber { get; set; }
        public string PatientIDNumber { get; set; }
        public string Authorization { get; set; }
        public string Deductible { get; set; }
        public string Copay { get; set; }
        public string Holder { get; set; }
        public Insurance()
        {

        }
    }
}
