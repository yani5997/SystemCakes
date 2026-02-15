namespace H.DTOs
{
    public class ClienteListadoDTO
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string? NombresPersona { get; set; }
        public string? ApellidosPersona { get; set; }
        public string? RazonSocial { get; set; }
    }
}