using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class User
    {
        // This will have the be required to Enter your name as email
        [Required(ErrorMessage = "Please Enter a name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please Enter your email")]
        public string? Email { get; set; }
    }
}
