using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models.ViewModel
{
    public class VmService
    {
        public List<Service> Services { get; set; }
        public Page Page { get; set; }
        public Setting Setting { get; set; }
        public Subscribe Subscribe { get; set; }
        public List<Social> Socials { get; set; }
        public List<Work> Works { get; set; }
    }
}
