using System.Threading.Tasks;

namespace APBD_7.Repositiries
{
    public interface IDbClientRepository
    {
        Task DeleteClientAsync(int idClient);
    }
}
