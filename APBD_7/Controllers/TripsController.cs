using APBD_7.Models.DTOs;
using APBD_7.Repositiries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APBD_7.Controllers
{
    [Route("api/trip")]
    [ApiController]
    public class TripsController : ControllerBase
    {

        private readonly IDbTripRepository _repository;

        public TripsController(IDbTripRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrips()
        {
            try
            {
                var trips = await _repository.GetTripsAsync();
                return Ok(trips);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }

        [HttpPost("{idTrip}/clients")]
        public async Task<IActionResult> AddTripToClient([FromRoute] int idTrip, [FromBody] AddTripToClientRequestDto dto)
        {
            try
            {
                await _repository.AddTripToClientAsync(idTrip, dto);
                return Ok(200);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
