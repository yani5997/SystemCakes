using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Models
{
    public partial class TCompraDetalle
    {
        /// <summary>
        /// Identificador de registro.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador de la compra realizada.
        /// </summary>
        public int IdCompra { get; set; }
        /// <summary>
        /// Identificador del insumo.
        /// </summary>
        public int IdInsumo { get; set; }
        /// <summary>
        /// Cantidad de insumos comprados.
        /// </summary>
        public decimal Cantidad { get; set; }
        /// <summary>
        /// Costo unitario de los insumos adquiridos.
        /// </summary>
        public decimal CostoUnitario { get; set; }
        /// <summary>
        /// Subtotal de la compra.
        /// </summary>
        public decimal Subtotal { get; set; }
        /// <summary>
        /// Estado del registro.
        /// </summary>
        public bool Estado { get; set; }
        /// <summary>
        /// Usuario de creación del registro
        /// </summary>
        public string UsuarioCreacion { get; set; } = null!;
        /// <summary>
        /// Usuario de modificación del registro
        /// </summary>
        public string? UsuarioModificacion { get; set; } = null!;
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Fecha de modificación del registro
        /// </summary>
        public DateTime? FechaModificacion { get; set; }
    }
}
