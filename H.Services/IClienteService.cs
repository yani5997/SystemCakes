using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface IClienteService
    {
        int Add(Cliente entidad);
        int Update(Cliente entidad);
        int Delete(int id, string usuario);
        Cliente GetById(int id);
        IEnumerable<ClienteListadoDTO> ObtenerCombo();
    }
}
