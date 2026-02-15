using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface IProductoService
    {
        int Add(Producto entidad);
        int Update(Producto entidad);
        int Delete(int id, string usuario);
        Producto GetById(int id);
        IEnumerable<ProductoListadoDTO> ObtenerCombo();
    }
}
