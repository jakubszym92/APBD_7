using System.ComponentModel.DataAnnotations;

namespace APBD_7.Models
{
    public partial class CountryTrip
    {
        [Key]
        public int IdCountry { get; set; }
        [Key]
        public int IdTrip { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual Trip IdTripNavigation { get; set; }
    }
}
