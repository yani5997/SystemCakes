namespace H.DTOs
{
    public class CompraDetalleListadoDTO
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }
        public int IdInsumo { get; set; }
        public string Insumo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal SubTotal { get; set; }
    }
}
