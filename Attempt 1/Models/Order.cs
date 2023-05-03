using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attempt_1.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
       
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public UserProfile userprofile { get; set; }

        public int WineID { get; set; }
        [ForeignKey("WineID")]
        public Wine wine { get; set; }

        public int SubID { get; set; }
        [ForeignKey("SubID")]
        public Subscription subscription { get; set; }

        public int Quantity { get; set; }
        public string DeliveryAdd { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public decimal? TotalCost { get; set;}
        public string OrderStatus { get; set; } 
        public int RewardPoints { get; set; }
        
    }
}
