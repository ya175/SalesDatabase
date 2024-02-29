using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }

        public DateTime Date { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}


//Sale:
// SaleId
// Date
// Product
// Customer
// Store