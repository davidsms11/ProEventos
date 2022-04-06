using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contracts
{
    public interface IPalestrantePersist
    {
         
       
       //Palestrantes

             Task<Palestrante[]> GetAllPalestrantesByNameAsync(string name, bool includeEventos);
            Task<Palestrante[]> GetAllPalestrantesAsync( bool includeEventos);
            Task<Palestrante> GetAPalestrantesByIdAsync(int palestranteId, bool includeEventos);
       
       

    }
}