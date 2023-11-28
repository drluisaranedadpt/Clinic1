using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicDPT.Entities
{
    public class PrimaryInsurance
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string InsuranceName { get; set; }
        [StringLength(250)]
        public string PolicyNumber { get; set; }
        [StringLength(250)]
        public string IdNumber { get; set; }
        [StringLength(250)]
        public string AddrAuthorizationNumber { get; set; }
        [StringLength(50)]
        public string Deductible { get; set; }
        [StringLength(50)]
        public string Copayment { get; set; }

        public PrimaryInsurance()
        {

        }
    }
}
