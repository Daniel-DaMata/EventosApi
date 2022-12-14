namespace EventosApi.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string DataFim { get; set; }
        public string DataInicio { get; set; }
        public string Endereco { get; set; }
        public bool Bebida { get; set; }
        public float Entrada { get; set; }
    }
}