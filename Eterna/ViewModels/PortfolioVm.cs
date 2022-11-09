using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.ViewModels
{
    public class PortfolioVm
    {
        public Portfolio Portfolio { get; set; }
        public List<Client> Clients { get; set; }
    }
}
