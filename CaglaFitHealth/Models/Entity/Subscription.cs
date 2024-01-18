using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaglaFitHealth.Models.Entity
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime SubscriptionDate { get; set; }

        public int? SubscriptionDuration { get; set; }

        [Required]
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member? Member { get; set; }

        [Required]
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public Trainer? Trainer { get; set; }
    }
}
