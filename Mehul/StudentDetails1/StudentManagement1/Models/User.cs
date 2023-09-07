using System.ComponentModel.DataAnnotations;

namespace StudentManagement1.Models
{
    public class User
    {
        [Key]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Role { get; set; }


    }
}
