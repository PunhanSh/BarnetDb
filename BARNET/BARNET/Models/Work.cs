using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models
{
    public class Work
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string SupTitle { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
