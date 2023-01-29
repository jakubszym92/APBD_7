using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD_7.Models
{
    public partial class Client
    {

        [Required]
        [Key]
        public int IdClient { get; set; }

        [Required]
        [MaxLength(120)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(120)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(120)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Telephone { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Pesel { get; set; }

        public virtual ICollection<ClientTrip> ClientTrips { get; set; }
        public Client()
        {
            ClientTrips = new HashSet<ClientTrip>();
        }


    }
}
