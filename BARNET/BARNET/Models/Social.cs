using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Link { get; set; }
        [MaxLength(100)]
        public string Icon { get; set; }

    }
}
