using sv_Aplicacion.Servicios;
using sv_ClienteEscritorio.VistasModelo;
using sv_Infraestructura.Modelos;
using sv_Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sv_ClienteEscritorio.Controladores
{
    public class ProductoControlador
    {
         ProductoServicio _productoServicio = new ProductoServicio(new ProductoRepositorio(new sv_senaContext()));

        public async Task<IEnumerable<ProductoVista>> ObtenerProductos()
        {
            var lstProductos = await _productoServicio.ObtenerProductos();

            List<ProductoVista> listaProductos = new List<ProductoVista>();

            foreach(var producto in lstProductos)
            {
                listaProductos.Add(new ProductoVista
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    CantidadTotal = producto.CantidadTotal
                });
            }

            return listaProductos;
        }
    }
}
