using APBD_7.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_7.Repositiries
{
    public class DbClientRepository : IDbClientRepository
    {

        private readonly Context _context;

        public DbClientRepository(Context context)
        {
            _context = context;
        }
        public async Task DeleteClientAsync(int idClient)
        {
            bool hasTrips = await _context.ClientTrips.AnyAsync(row => row.IdClient == idClient);

            if (hasTrips) throw new Exception("Client has one or more trips!");

            Client client = await _context.Clients.Where(row => row.IdClient == idClient).FirstOrDefaultAsync();
            _context.Remove(client);

            await _context.SaveChangesAsync();
        }
    }
}
