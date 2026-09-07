using System.ComponentModel.DataAnnotations;

namespace Lab11.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }

        public string Course { get; set; }

        public string Batch { get; set; }

        [Display(Name = "Joined Year")]
        public int JoinedYear { get; set; }
    }
}