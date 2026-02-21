namespace H.DTOs
{
    public class CompraInsertDTO
    {
        public string UsuarioCreacion { get; set; }
        public List<CompraDetalleInsertDTO> Detalles { get; set; }
    }

    public class CompraDetalleInsertDTO
    {
        public int IdInsumo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
    }
}