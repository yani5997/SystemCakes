using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface IUsuarioRolService
    {
        int Add(UsuarioRol entidad);
        int Update(UsuarioRol entidad);
        int Delete(int id, string usuario);
        UsuarioRol GetById(int id);
        /*IEnumerable<UsuarioRolListadoDTO> ObtenerCombo();*/
    }
}
