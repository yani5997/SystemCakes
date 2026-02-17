using AutoMapper;
using Dapper;
using H.DataAccess.Entidades;
using H.DataAccess.Enums;
using H.DataAccess.Infrastructure;
using H.DataAccess.Log;
using H.DataAccess.Models;
using H.DataAccess.Repositorios;
using H.DTOs;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Repositorios
{
    public class UsuarioRepository : GenericRepository<TUsuario>, IUsuarioRepository
    {
        private Mapper mapper;
        public UsuarioRepository(sistemContext context, IConnectionFactory connectionFactory) : base(context, connectionFactory)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Usuario, TUsuario>(MemberList.None).ReverseMap());
            mapper = new Mapper(config);
        }

        public TUsuario Add(Usuario entidad)
        {
            try
            {
                var modelo = mapper.Map<TUsuario>(entidad);
                base.Add(modelo);
                return modelo;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "UsuarioRepository" + ex.Message;
                error.Exception = ex;
                error.Operation = "Add";
                error.Code = TiposError.NoInsertado;
                error.Objeto = JsonConvert.SerializeObject(entidad);
                LogErp.EscribirBaseDatos(error);

                throw ex;
            }
        }

        public TUsuario Update(Usuario entidad)
        {
            try
            {
                var modelo = mapper.Map<TUsuario>(entidad);
                base.Update(modelo);
                return modelo;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "UsuarioRepository" + ex.Message;
                error.Exception = ex;
                error.Operation = "Update";
                error.Code = TiposError.NoActualizado;
                error.Objeto = JsonConvert.SerializeObject(entidad);
                LogErp.EscribirBaseDatos(error);

                throw ex;
            }
        }

        public int Delete(int id, string usuario)
        {
            try
            {
                base.Delete(id, usuario);
                return id;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "UsuarioRepository" + ex.Message;
                error.Exception = ex;
                error.Operation = "Delete";
                error.Code = TiposError.NoEliminado;
                error.Objeto = JsonConvert.SerializeObject(new { id, usuario });
                LogErp.EscribirBaseDatos(error);

                throw ex;
            }
        }

        public Usuario GetById(int id)
        {
            try
            {
                var modelo = base.GetById(id);
                return mapper.Map<Usuario>(modelo);
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "UsuarioRepository" + ex.Message;
                error.Exception = ex;
                error.Operation = "GetById";
                error.Code = TiposError.NoEncontrado;
                error.Objeto = JsonConvert.SerializeObject(id);
                LogErp.EscribirBaseDatos(error);

                throw ex;
            }
        }


        /*public TUsuario GetByUsername(string username)
        {
            return _context.TUsuarios
                .Include(x => x.UsuarioRoles)
                .ThenInclude(x => x.Rol)
                .FirstOrDefault(x => x.Username == username && x.Estado);
        }*/


        /*public IEnumerable<UsuarioListadoDTO> ObtenerCombo()
        {
            try
            {
                var query = "SP_Usuario_ListadoActivo_Combo";
                using (var conn = connectionFactory.GetConnection)
                {
                    var rpta = SqlMapper.Query<UsuarioListadoDTO>(conn, query, param: null, commandType: CommandType.StoredProcedure);
                    return rpta.ToList();
                }
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "UsuarioRepository" + ex.Message;
                error.Exception = ex;
                error.Operation = "ObtenerCombo";
                error.Code = TiposError.NoInsertado;
                error.Objeto = JsonConvert.SerializeObject(null);
                LogErp.EscribirBaseDatos(error);

                throw ex;
            }
        }*/
    }
}
