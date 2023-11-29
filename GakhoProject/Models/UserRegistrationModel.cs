using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GakhoProject.Models
{
    public class UserRegistrationModel

    {
        [Required]
        [EmailAddress]
        [DisplayName("Email Adress")]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [DisplayName("Confrim Password")]
        public string? ConfirmPassword { get; set; }

    }
}



