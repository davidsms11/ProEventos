namespace ProEventos.Domain
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        public int? PalestranteId { get; set; }
         public Palestrante Palestrante { get; set; }
    }
}