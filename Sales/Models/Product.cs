using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

       public List<Sale> Sales { get; set; }
        public string Descreption { get; set; }
        

    }
}



//ProductId
// Name(up to 50 characters, unicode)
// Quantity(real number)
// Price
// Sales