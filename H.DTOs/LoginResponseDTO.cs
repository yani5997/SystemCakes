using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DTOs
{
        public class LoginResponseDTO
        {
            public int IdUsuario { get; set; }
            public string Username { get; set; } = null!;
            public string Token { get; set; } = null!;
            public string TipoUsuario { get; set; } = null!;
            public List<string> Roles { get; set; } = new List<string>();
            public PersonaDTO? Persona { get; set; }
        }
    
}
