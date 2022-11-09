using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Tittle { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }




        public List<BlogSingle> BlogDetails { get; set; }












    }
}
