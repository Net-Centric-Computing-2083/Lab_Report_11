using System.ComponentModel.DataAnnotations;

namespace Lab_Report_11.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string ?Phone { get; set; }

        [Required]
        public string ?Course { get; set; }

        [Required]
        public string? Batch { get; set; }

        [Required]
        public int JoinedYear { get; set; }
    }
}