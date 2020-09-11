using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sv_Aplicacion.IRepositorios;
using sv_Dominio.Entidades;
using sv_Infraestructura.Modelos;

namespace sv_Infraestructura.Repositorios
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private readonly sv_senaContext _contexto;

        public ProductoRepositorio(sv_senaContext contexto)
        {
            _contexto = contexto;
        }

        public void ActualizarProducto(Producto producto)
        {
            _contexto.Entry(new Productos
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                CantidadTotal = producto.CantidadTotal,
                FechaCreacion = producto.FechaCreacion,
                FechaModificacion = producto.FechaModificacion,
                IdCreador = producto.IdCreador,
                IdModificador = producto.IdModificador,
                PrecioVentaActual = producto.PrecioVentaActual
            }).State = EntityState.Modified;
        }

        public void CrearProducto(Producto producto)
        {
            _contexto.Productos.Add(new Productos
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                CantidadTotal = producto.CantidadTotal,
                FechaCreacion = producto.FechaCreacion,
                FechaModificacion = producto.FechaModificacion,
                IdCreador = producto.IdCreador,
                IdModificador = producto.IdModificador,
                PrecioVentaActual = producto.PrecioVentaActual
            });
        }

        public async void EliminarProducto(int id)
        {
            var producto = await _contexto.Productos.FindAsync(id);
            _contexto.Remove(producto);
        }

        public async Task<bool> GuardarCambios()
        {
            var resultado = await _contexto.SaveChangesAsync();
            if (resultado >= 0)
                return true;
            else
                return false;
        }

        public async Task<Producto> ObtenerProductoPorId(int id)
        {
            var producto = await _contexto.Productos.FindAsync(id);

            return new Producto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                CantidadTotal = producto.CantidadTotal,
                FechaCreacion = producto.FechaCreacion,
                FechaModificacion = producto.FechaModificacion,
                IdCreador = producto.IdCreador,
                IdModificador = producto.IdModificador,
                PrecioVentaActual = producto.PrecioVentaActual
            };

        }

        public async Task<IEnumerable<Producto>> ObtenerProductos()
        {
            var productos = await _contexto.Productos.ToListAsync();

            List<Producto> listaProductos = new List<Producto>();
            foreach (var producto in productos)
            {
                listaProductos.Add(new Producto
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    CantidadTotal = producto.CantidadTotal,
                    FechaCreacion = producto.FechaCreacion,
                    FechaModificacion = producto.FechaModificacion,
                    IdCreador = producto.IdCreador,
                    IdModificador = producto.IdModificador,
                    PrecioVentaActual = producto.PrecioVentaActual
                });
            }

            return listaProductos;
        }
    }
}
