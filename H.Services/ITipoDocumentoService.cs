using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface ITipoDocumentoService
    {
        int Add(TipoDocumento entidad);
        int Update(TipoDocumento entidad);
        int Delete(int id, string usuario);
        TipoDocumento GetById(int id);
        IEnumerable<TipoDocumentoListadoDTO> ObtenerCombo();
    }
}
