using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class PortfolioDetail
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public DateTime DateTime { get; set; }
        public string ProjectUrl { get; set; }

        public string Tittle { get; set; }
        public string Description { get; set; }




        public List<Portfolio> Portfolios { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }

    }
}
