﻿using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.ViewModels
{
    public class AboutVm
    {
        public About Abouts { get; set; }
        public List<Client> Clients { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
