namespace H.DTOs
{
    public class ProductoListadoDTO
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }
        public string NombreCategoria { get; set; }
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal Igv { get; set; }
    }
}