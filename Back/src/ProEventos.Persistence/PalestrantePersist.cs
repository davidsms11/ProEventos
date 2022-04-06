using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Context;
using ProEventos.Persistence.Contracts;

namespace ProEventos.Persistence
{
    public class PalestrantePersist : IPalestrantePersist
    {
        private readonly ProEventosContext _context;

        public PalestrantePersist(ProEventosContext context)
            {
            _context = context;
        }
     
     
              

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p=> p.SocialMedias);

          

           if(includeEventos)
           {
                query = query.Include(e=> e.PalestrantesEventos)
                .ThenInclude(pe=> pe.Evento);
           }

            query = query.AsNoTracking().OrderBy(p=> p.Id);

           return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNameAsync(string name, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(p=> p.SocialMedias);

          

           if(includeEventos)
           {
                query = query.Include(e=> e.PalestrantesEventos)
                .ThenInclude(pe=> pe.Evento);
           }

            query = query.AsNoTracking().OrderBy(p=> p.Id).Where(p=> p.Name.ToLower().Contains(name.ToLower()));

           return await query.ToArrayAsync();
        }

        

        public async Task<Palestrante> GetAPalestrantesByIdAsync(int palestranteId, bool includeEventos)
        {
             IQueryable<Palestrante> query = _context.Palestrantes.Include(p=> p.SocialMedias);

          

           if(includeEventos)
           {
                query = query.Include(e=> e.PalestrantesEventos)
                .ThenInclude(pe=> pe.Evento);
           }

            query = query.AsNoTracking().OrderBy(p=> p.Id).Where(p=> p.Id == palestranteId);

           return await query.FirstOrDefaultAsync();
        }

    
    }
}