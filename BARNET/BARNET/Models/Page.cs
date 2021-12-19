using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(300)]
        public string ServiceHead { get; set; }
        [MaxLength(300)]
        public string WorkHead { get; set; }
        [MaxLength(300)]
        public string SliderHead { get; set; }
    }
}
