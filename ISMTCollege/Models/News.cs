using System.ComponentModel.DataAnnotations;

namespace ISMTCollege.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "News title is required")]
        [Display(Name = "Title")]
        [StringLength(200, ErrorMessage = "Title cannot be longer than 200 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "News content is required")]
        [Display(Name = "Content")]
        public string Content { get; set; } = string.Empty;

        [Display(Name = "Published At")]
        public DateTime PublishedAt { get; set; } = DateTime.Now;

        [Display(Name = "Is Published")]
        public bool IsPublished { get; set; } = true;

        [Display(Name = "Featured Image")]
        public string? FeaturedImage { get; set; }

        [Display(Name = "Category")]
        [StringLength(100, ErrorMessage = "Category cannot be longer than 100 characters")]
        public string? Category { get; set; }
    }
}
