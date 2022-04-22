using System.ComponentModel.DataAnnotations;

namespace hobinhan.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public string Title { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(500)]
        [MinLength(100)]
        public string Content { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime CreateAt { get; set; }
        public Category Category { get; set; } 

        public List<Comment> Comments { get; set; }




    }
}
