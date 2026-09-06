using System.ComponentModel.DataAnnotations;

namespace Lab_Report_11.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Course { get; set; } = string.Empty;

        [Required]
        public string Batch { get; set; } = string.Empty;

        [Display(Name = "Joined Year")]
        [Required]
        public int JoinedYear { get; set; }
    }
}