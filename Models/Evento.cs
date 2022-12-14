namespace EventosApi.Models
{
    public class Evento
    {
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }
        public string Endereco { get; set; }
        public bool Bebida { get; set; }
        public float Entrada { get; set; }
    }
}