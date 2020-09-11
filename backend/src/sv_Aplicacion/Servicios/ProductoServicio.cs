using sv_Aplicacion.IRepositorios;
using sv_Aplicacion.IServicios;
using sv_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sv_Aplicacion.Servicios
{
    public class ProductoServicio : IProductoServicios
    {
        private readonly IProductoRepositorio _ProductoRepositorio;

        public ProductoServicio(IProductoRepositorio productoRepositorio)
        {
            _ProductoRepositorio = productoRepositorio;
        }

        public void ActualizarProducto(int id, Producto producto)
        {
            var validar = _ProductoRepositorio.ObtenerProductoPorId(id);

            if (id != validar.Id) throw new Exception();

            try
            {
                _ProductoRepositorio.ActualizarProducto(producto);

            } catch (Exception)
            {
                throw new Exception();
            }


        }

        public void CrearProducto(Producto producto)
        {
            _ProductoRepositorio.CrearProducto(producto);
        }

        public void EliminarProducto(int id)
        {
            _ProductoRepositorio.EliminarProducto(id);
        }

        public async Task<bool> GuardarCambios()
        {
            return await _ProductoRepositorio.GuardarCambios();
        }

        public async Task<Producto> ObtenerProductoPorId(int id)
        {
            return await _ProductoRepositorio.ObtenerProductoPorId(id);
        }

        public async Task<IEnumerable<Producto>> ObtenerProductos()
        {
            return await _ProductoRepositorio.ObtenerProductos();
        }
    }
}
