using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sv_Aplicacion.IServicios;
using sv_Dominio.Entidades;
using sv_WebApi.ModelosVistas.Productos;

namespace sv_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoServicios _productoServicios;

        public ProductosController(IProductoServicios productoServicios)
        {
            _productoServicios = productoServicios;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoLeer>>> ObtenerProductos()
        {
            var productos = await _productoServicios.ObtenerProductos();

            List<ProductoLeer> listaProdcutos = new List<ProductoLeer>();
            foreach (var producto in productos)
            {
                listaProdcutos.Add(new ProductoLeer
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    PrecioVentaActual = producto.PrecioVentaActual,
                    CantidadTotal = producto.CantidadTotal
                });
            }

            return Ok(listaProdcutos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoLeer>> ObtenerProductoPorId([FromRoute] int id)
        {
            var producto = await _productoServicios.ObtenerProductoPorId(id);

            if (producto == null) return NotFound(new { mensaje = "El producto que busca no existe" });

            return Ok(new ProductoLeer
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                CantidadTotal = producto.CantidadTotal,
                Descripcion = producto.Descripcion,
                PrecioVentaActual = producto.PrecioVentaActual
            });
        }

        [HttpPost]
        public async Task<ActionResult<ProductoLeer>> CrearProducto([FromBody] ProductoCrear producto)
        {
            _productoServicios.CrearProducto(new Producto
            {
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion                
            });

            var resultado = await _productoServicios.GuardarCambios();

            if (resultado) return Ok(new { mensaje = "Producto creado con exitos" });

            return BadRequest();
        }
    }
}
