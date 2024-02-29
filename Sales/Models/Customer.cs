using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    internal class Customer
    {

        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string CreaditCardNumber { get; set; }
        public List<Sale> Sales { get; set; }
    }
}


//CustomerId
// Name (up to 100 characters, unicode)
// Email (up to 80 characters, not unicode)
// CreaditCardNumber (string)
// Sales