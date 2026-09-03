using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Course { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Batch { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Joined Year")]
        [Range(1900, 2100)]
        public int JoinedYear { get; set; }
    }
}
