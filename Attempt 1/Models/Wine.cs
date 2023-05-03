using System.ComponentModel.DataAnnotations;

namespace Attempt_1.Models
{
	public class Wine
	{
		[Key]
		public int WineID { get; set; }
		public string? WineName { get; set; }
		public string? Image { get; set; }
		public decimal Price { get; set; }
		public string? Blurb { get; set; }
		public int Quantity { get; set; }
		public string? Type { get; set; }
		public string? Category { get; set; }
	}
}
