using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sv_WebApi.ModelosVistas.Productos
{
    public class ProductoLeer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioVentaActual { get; set; }
        public int CantidadTotal { get; set; }
    }
}
