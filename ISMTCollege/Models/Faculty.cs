using System.ComponentModel.DataAnnotations;

namespace ISMTCollege.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Faculty name is required")]
        [Display(Name = "Full Name")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Designation is required")]
        [Display(Name = "Designation")]
        [StringLength(100, ErrorMessage = "Designation cannot be longer than 100 characters")]
        public string Designation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [StringLength(100, ErrorMessage = "Department cannot be longer than 100 characters")]
        public string Department { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        [StringLength(20, ErrorMessage = "Phone number cannot be longer than 20 characters")]
        public string? Phone { get; set; }

        [Display(Name = "Profile Image")]
        public string? ProfileImage { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;
    }
}
