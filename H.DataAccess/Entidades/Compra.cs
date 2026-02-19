using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Entidades
{
    public class Compra: BaseEntity
    {
        public string? FechaCompra { get; set; }
        public decimal? Total { get; set; }
    }
}
