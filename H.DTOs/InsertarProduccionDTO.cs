namespace H.DTOs
{
    public class InsertarProduccionDTO
    {
        public DateTime? Fecha { get; set; }
        public int IdTorta { get; set; }
        public int CantidadProducida { get; set; }
        public string? Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}