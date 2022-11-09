using Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.ViewModels
{
    public class BlogVm
    {
        public Blog Blog { get; set; }
        public List<Category> Categories { get; set; }
        public List<RecentPost> RecentPosts { get; set; }
        public List<Tag> Tags { get; set; }


    }
}
