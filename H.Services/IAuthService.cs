using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> Login(LoginRequestDTO request);
        Task<RegisterResponseDTO> RegisterCliente(RegisterClienteRequestDTO request);
        Task<RegisterResponseDTO> RegisterAdministrador(RegisterAdministradorRequestDTO request);
        Task<bool> ValidarToken(string token);
        public string GenerarToken(Usuario usuario, List<string> roles);
        /*Task<bool> ExisteUsername(string username);*/
    }
}
