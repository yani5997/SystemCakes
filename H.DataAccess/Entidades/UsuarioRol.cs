using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Entidades
{
    public class UsuarioRol: BaseEntity
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        }
}
