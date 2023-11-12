using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace GakhoProject.Models
{
    public class UserRegistraionModel
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
