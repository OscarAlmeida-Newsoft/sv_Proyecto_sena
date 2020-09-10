using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using sv_Aplicacion.IRepositorios;
using sv_Dominio.Entidades;

namespace sv_Infraestructura.Repositorios
{
    public class ProductosRepositorio : IProductoRepositorio
    {

        public void ActualizarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void CrearProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void EliminarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> ObtenerProductoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Producto>> ObtenerProductos()
        {
            throw new NotImplementedException();
        }
    }
}
