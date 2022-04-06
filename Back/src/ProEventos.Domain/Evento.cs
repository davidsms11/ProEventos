using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int Qtd { get; set; } 
        public string Lote { get; set; }    
        public string ImagenUrl { get; set; }
        public string Nummber { get; set; }
        public string Email { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }

        public IEnumerable<SocialMedia> SocialMedias { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}