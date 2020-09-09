using sv_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sv_Aplicacion.IServicios
{
    public interface IProductosServicios
    {
        void CrearProducto(Producto producto);
        Task<IEnumerable<Producto>> ObtenerProductos();
        Task<Producto> ObtenerProductoPorId(int id);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int id);
        Task<bool> GuardarCambios();
    }
}
