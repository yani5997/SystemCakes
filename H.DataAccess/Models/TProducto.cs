using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Models
{
    public partial class TProducto
    {
        /// <summary>
        /// Identificador de registro.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador de la categoria del producto.
        /// </summary>
        public int IdCategoria { get; set; }
        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string Nombre { get; set; } = null!;
        /// <summary>
        /// Descripcion del producto.
        /// </summary>
        public string Descripcion { get; set; } = null!;
        /// <summary>
        /// Stock del producto.
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Fecha de vencimiento del producto.
        /// </summary>
        public DateTime FechaVencimiento { get; set; }
        /// <summary>
        /// Costo unitario del producto.
        /// </summary>
        public decimal CostoUnitario { get; set; } 
        /// <summary>
        /// Costo total del producto.
        /// </summary>
        public decimal CostoTotal { get; set; }
        /// <summary>
        /// Igv del producto.
        /// </summary>
        public decimal Igv { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool Estado { get; set; }
        /// <summary>
        /// Usuario de creación del registro
        /// </summary>
        public string UsuarioCreacion { get; set; } = null!;
        /// <summary>
        /// Usuario de modificación del registro
        /// </summary>
        public string UsuarioModificacion { get; set; } = null!;
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Fecha de modificación del registro
        /// </summary>
        public DateTime FechaModificacion { get; set; }
    }
}
