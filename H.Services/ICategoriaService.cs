using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface ICategoriaService
    {
        int Add(Categoria entidad);
        int Update(Categoria entidad);
        int Delete(int id, string usuario);
        Categoria GetById(int id);
        IEnumerable<CategoriaListadoDTO> ObtenerCombo();
    }
}
