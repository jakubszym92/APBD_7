using APBD_7.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBD_7.Repositiries
{
    public interface IDbTripRepository
    {
        Task<IEnumerable<GetTripsResponseDto>> GetTripsAsync();
        Task AddTripToClientAsync(int idTrip, AddTripToClientRequestDto dto);
    }
}
