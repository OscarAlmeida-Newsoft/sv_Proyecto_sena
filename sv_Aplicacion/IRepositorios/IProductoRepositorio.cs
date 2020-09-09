using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using sv_Dominio.Entidades;

namespace sv_Aplicacion.IRepositorios
{
    public interface IProductoRepositorio
    {
        Task<IEnumerable<Producto>> ObtenerProductos();
        Task<Producto> ObtenerProductoPorId(int id);
        void CrearProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int id);
        Task<bool> GuardarCambios();
    }
}
