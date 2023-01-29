using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD_7.Models
{
    public partial class Trip
    {
        public Trip()
        {
            ClientTrips = new HashSet<ClientTrip>();
            CountryTrips = new HashSet<CountryTrip>();
        }

        [Key]
        public int IdTrip { get; set; }

        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        [MaxLength(220)]
        public string Description { get; set; }
        
        [Required]
        public DateTime DateFrom { get; set; }
        
        [Required]
        public DateTime DateTo { get; set; }
        
        [Required]
        public int MaxPeople { get; set; }

        public virtual ICollection<ClientTrip> ClientTrips { get; set; }
        public virtual ICollection<CountryTrip> CountryTrips { get; set; }
    }
}
