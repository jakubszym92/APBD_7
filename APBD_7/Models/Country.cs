using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBD_7.Models
{
    public partial class Country
    {
        public Country()
        {
            CountryTrips = new HashSet<CountryTrip>();
        }
        [Key]
        public int IdCountry { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<CountryTrip> CountryTrips { get; set; }
    }
}
