using System.ComponentModel.DataAnnotations;

namespace GakhoProject.Models
{
	public class PolitParties
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(50)]
		public string? YourFullName { get; set; }
		[Required]
		[MaxLength(50)]
		public string? PartiesName { get; set; }
		public DateTime? DateOfBirth { get; set; }
	}
}
