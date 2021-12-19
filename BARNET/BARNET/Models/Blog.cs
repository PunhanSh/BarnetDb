using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BARNET.Models
{
    public class Blog
    {
       [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Title { get; set; }
        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        [Column(TypeName ="ntext")]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(500)]
        public string SubTitle { get; set; }
    }
}
