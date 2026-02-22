namespace H.DTOs
{
    public class ProduccionListadoDTO
    {
        public int Id { get; set; }
        public int IdTorta { get; set; }
        public string Torta { get; set; }
        public string Fecha { get; set; }
        public string CantidadProducida { get; set; }
        public string? Observacion { get; set; }
    }
}