using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H.DataAccess.Entidades;
using H.DataAccess.Models;
using H.DataAccess.Repositorios;
using H.DTOs;

namespace H.DataAccess.Repositorios
{
    public interface ICategoriaRepository : IGenericRepository<TCategoria>
    {
        TCategoria Add(Categoria entidad);
        int Delete(int id, string usuario);
        TCategoria Update(Categoria entidad);
        Categoria GetById(int id);
        IEnumerable<CategoriaListadoDTO> ObtenerCombo();
    }
}
