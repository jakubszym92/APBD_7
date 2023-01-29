using APBD_7.Repositiries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APBD_7.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        private readonly IDbClientRepository _repository;

        public ClientsController(IDbClientRepository repository)
        {
            _repository = repository;
        }

        [HttpDelete("{idClient}")]
        public async Task<IActionResult> DeleteClient([FromRoute] int idClient)
        {
            try
            {
                await _repository.DeleteClientAsync(idClient);
                return Ok(200);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }
}
