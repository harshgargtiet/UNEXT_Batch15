using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models
{
    public class User
    {
        [Key] // data annotation, now username is primary key
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}
