﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class Product
    {
        public int Id { get; set; } //primarykey
        public int CategoryId { get; set; } //foreingkey
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
