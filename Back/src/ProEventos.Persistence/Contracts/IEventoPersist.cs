using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contracts
{
    public interface IEventoPersist
    {
        

//EVENTS
          Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
            Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
          
            Task<Evento> GetEventosByIdAsync(int eventoId, bool includePalestrantes = false);
     
    }
}