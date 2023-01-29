using System;
using System.ComponentModel.DataAnnotations;

namespace APBD_7.Models
{
    public partial class ClientTrip
    {
        [Key]
        public int IdClient { get; set; }
        
        [Required]
        public int IdTrip { get; set; }
        [Required]
        public DateTime RegisteredAt { get; set; }
       
        public DateTime? PaymentDate { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Trip IdTripNavigation { get; set; }
    }
}
