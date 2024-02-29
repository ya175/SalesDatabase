﻿using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    internal class Store
    {

        public int StoreId { get; set; }
        public string Name { get; set; }
        public List<Sale> Sales { get; set; }
    }
}