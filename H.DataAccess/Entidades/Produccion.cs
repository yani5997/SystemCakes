using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Entidades
{
    public class Produccion : BaseEntity
    {
        public int IdTorta {  get; set; }
        public DateTime Fecha { get; set; }
        public decimal CantidadProducida {  get; set; } 
        public string? Observacion { get; set; }
    }
}
