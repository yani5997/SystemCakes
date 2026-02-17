using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DTOs
{
    public class RegisterResponseDTO
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; } = null!;
        public string Mensaje { get; set; } = null!;
    }
}
