using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models.ViewModel
{
    public class VmBlog
    {
        public List<Blog> Blogs { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public Banner Banner { get; set; }
        public List<User> Users { get; set; }
    }
}
