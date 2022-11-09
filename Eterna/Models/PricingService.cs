using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class PricingService
    {

        public int Id { get; set; }

        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public int PrServiceId { get; set; }
        public PrService PrService { get; set; }
    }
}
