using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface ICompraService
    {
        int Add(Compra entidad);
        int Update(Compra entidad);
        int Delete(int id, string usuario);
        Compra GetById(int id);
        IEnumerable<CompraListadoDTO> ObtenerCombo();
    }
}
