using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string CV { get; set; }
        public string ImgURL { get; set; }
        public  string Nummber { get; set; }
        public string Email { get; set; }
        public int EventoId { get; set; }
           
        public IEnumerable<SocialMedia> SocialMedias { get; set; }

         public IEnumerable<PalestranteEvento> PalestrantesEventos{ get; set; }
    }
}