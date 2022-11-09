﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Pricing
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsFeatured { get; set; }



        public List<PricingService> PricingServices { get; set; }
    }
}
