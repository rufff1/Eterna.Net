﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }


        public List<PortfolioDetail> PortfolioDetails { get; set; }

   

    }
}
