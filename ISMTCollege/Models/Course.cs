using System.ComponentModel.DataAnnotations;

namespace ISMTCollege.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [Display(Name = "Course Name")]
        [StringLength(200, ErrorMessage = "Course name cannot be longer than 200 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course duration is required")]
        [Display(Name = "Duration")]
        [StringLength(50, ErrorMessage = "Duration cannot be longer than 50 characters")]
        public string Duration { get; set; } = string.Empty;

        [Display(Name = "Fees")]
        [DataType(DataType.Currency)]
        public decimal? Fees { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;
    }
}
