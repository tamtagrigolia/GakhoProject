using System.ComponentModel.DataAnnotations;

namespace GakhoProject.Models
{
    public class Member
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string  ? FullName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Desc { get; set; }
    }
}
