using System;

namespace ProEventos.Domain
{
    public class Lote
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int  Qtd { get; set; }
        public int EventoId { get; set; }
         public Evento  Evento { get; set; }
    }
}