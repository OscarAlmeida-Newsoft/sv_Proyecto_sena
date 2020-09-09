using sv_Aplicacion.IRepositorios;
using sv_Aplicacion.IServicios;
using sv_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sv_Aplicacion.Servicios
{
    public class ProductoServicio : IProductosServicios
    {
        private readonly IProductoRepositorio _ProductoRepositorio;

        public void ActualizarProducto(Producto producto)
        {
            _ProductoRepositorio.ActualizarProducto(producto);
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
