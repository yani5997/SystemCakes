using H.DataAccess.Entidades;
using H.DTOs;

namespace H.Services
{
    public interface IProduccionService
    {
        int Add(Produccion entidad);
        int Update(Produccion entidad);
        int Delete(int id, string usuario);
        Produccion GetById(int id);
        public int AddMultipleTabla(InsertarProduccionDTO dto);
    }
}
