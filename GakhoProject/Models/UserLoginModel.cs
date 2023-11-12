using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GakhoProject.Models
{
    public class UserLoginModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email Address")]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DisplayName("Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
