namespace ProAgil.WebAPI.model
{
    public class Evento
    {
        public int eventoId { get; set; }
        public string local { get; set; }
        public string dataEvento { get; set; }
        public string tema { get; set; }
        public int qtsPessoas { get; set; }
        public string lote { get; set; }
        public string imagemUrl { get; set; }
    }
}