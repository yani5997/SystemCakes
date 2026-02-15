using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Entidades
{
    public class Producto : BaseEntity
    {
        public int IdCategoria {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; } 
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal Igv { get; set; }
    }
}
