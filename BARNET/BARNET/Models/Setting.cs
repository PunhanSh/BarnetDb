using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(1000)]
        public string FooterContent { get; set; }

    }
}
