using H.DataAccess.Entidades;
using H.DataAccess.Enums;
using H.DataAccess.Helpers;
using H.DataAccess.Log;
using H.DataAccess.Models;
using H.DataAccess.UnitofWork;
using H.DTOs;
using Newtonsoft.Json;

namespace H.Services
{
    public class CompraDetalleService: ICompraDetalleService
    {
        private IUnitOfWork _unitOfWork;
        public CompraDetalleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int Add(CompraDetalle entidad)
        {
            try
            {
                var modelo = _unitOfWork.CompraDetalleRepository.Add(entidad);
                _unitOfWork.Commit();
                return modelo.Id;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "AlmacenService" + ex.Message;
                error.Exception = ex;
                error.Operation = "Add";
                error.Code = TiposError.NoInsertado;
                error.Objeto = JsonConvert.SerializeObject(entidad);

                LogErp.EscribirBaseDatos(error);
                throw ex;
            }
        }

        public int Update(CompraDetalle entidad)
        {
            try
            {
                var modelo = _unitOfWork.CompraDetalleRepository.Update(entidad);
                _unitOfWork.Commit();
                return modelo.Id;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "CompraDetalleService" + ex.Message;
                error.Exception = ex;
                error.Operation = "Update";
                error.Code = TiposError.NoInsertado;
                error.Objeto = JsonConvert.SerializeObject(entidad);

                LogErp.EscribirBaseDatos(error);
                throw ex;
            }
        }

        public int Delete(int id, string usuario)
        {
            try
            {
                var rpta = _unitOfWork.CompraDetalleRepository.Delete(id, usuario);
                _unitOfWork.Commit();
                return rpta;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "CompraDetalleService" + ex.Message;
                error.Exception = ex;
                error.Operation = "Delete";
                error.Code = TiposError.NoEliminado;
                error.Objeto = JsonConvert.SerializeObject(new { id, usuario });

                LogErp.EscribirBaseDatos(error);
                throw ex;
            }
        }

        public CompraDetalle GetById(int id)
        {
            try
            {
                return _unitOfWork.CompraDetalleRepository.GetById(id);
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "CompraDetalleService" + ex.Message;
                error.Exception = ex;
                error.Operation = "Update";
                error.Code = TiposError.NoEncontrado;
                error.Objeto = JsonConvert.SerializeObject(id);

                LogErp.EscribirBaseDatos(error);
                throw ex;
            }
        }

        public IEnumerable<CompraDetalleListadoDTO> ObtenerCombo()
		{
			try
			{
				return _unitOfWork.CompraDetalleRepository.ObtenerCombo();
			}
			catch (Exception ex)
			{
				var error = new Error();
				error.Message = "CompraDetalleService" + ex.Message;
				error.Exception = ex;
				error.Operation = "ObtenerListadoActivos";
				error.Code = TiposError.NoEncontrado;
				error.Objeto = JsonConvert.SerializeObject(null);

				LogErp.EscribirBaseDatos(error);
				throw ex;
			}
		}

        public int AddMultipleTabla(CompraInsertDTO dto)
        {
            try
            {
                decimal total = 0;
                var fechaActual = Fecha.Hoy;

                var compra = new TCompra
                {
                    FechaCompra = fechaActual,
                    Estado = true,
                    UsuarioCreacion = dto.UsuarioCreacion,
                    FechaCreacion = fechaActual,
                    FechaModificacion = fechaActual
                };
                _unitOfWork.CompraRepository.Add(compra);
                _unitOfWork.Commit();
                var idCompra = compra.Id;

                foreach (var item in dto.Detalles)
                {
                    var subtotal = item.Cantidad * item.CostoUnitario;
                    total += subtotal;

                    var detalle = new TCompraDetalle
                    {
                        IdCompra = idCompra,
                        IdInsumo = item.IdInsumo,
                        Cantidad = item.Cantidad,
                        CostoUnitario = item.CostoUnitario,
                        Subtotal = subtotal,
                        Estado = true,
                        UsuarioCreacion = dto.UsuarioCreacion,
                        UsuarioModificacion = dto.UsuarioCreacion,
                        FechaCreacion = fechaActual,
                        FechaModificacion = fechaActual
                    };

                    _unitOfWork.CompraDetalleRepository.Add(detalle);

                    var insumo = _unitOfWork.InsumoRepository.GetById(item.IdInsumo);
                    insumo.StockActual += item.Cantidad;
                    _unitOfWork.InsumoRepository.Update(insumo);
                }

                compra.Id = idCompra;
                compra.Total = total;

                _unitOfWork.CompraRepository.Update(compra);
                _unitOfWork.Commit();

                return idCompra;
            }
            catch (Exception ex)
            {
                var error = new Error();
                error.Message = "AlmacenService" + ex.Message;
                error.Exception = ex;
                error.Operation = "Add";
                error.Code = TiposError.NoInsertado;
                error.Objeto = JsonConvert.SerializeObject(dto);

                LogErp.EscribirBaseDatos(error);
                throw ex;
            }
        }
    }
}
