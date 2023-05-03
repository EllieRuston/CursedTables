using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attempt_1.Models
{
	public class UserProfile
	{
		[Key]
		public int UserID { get; set; }
		public string FullName { get; set; }
		public string DeliveryAdd { get; set; }
		public string Email { get; set; }
		
		[DataType(DataType.Date)]
		public DateTime DOB { get; set; }
		public string Phone { get; set; }
		public int RewardPoints { get; set; }
		public string Role { get; set; }

	}
}
