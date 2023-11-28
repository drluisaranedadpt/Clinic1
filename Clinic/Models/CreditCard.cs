using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CreditCardName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CardNumber { get; set; }
        public string ExpDate { get; set; }
        public string Code { get; set; }
        public string CardType { get; set; }
        public CreditCard()
        {

        }
    }
}
