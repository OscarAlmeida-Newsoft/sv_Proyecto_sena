using System;
using System.Collections.Generic;
using System.Text;

namespace sv_ClienteEscritorio.VistasModelo.Producto
{
    public class ProductoDetallez
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioVentaActual { get; set; }
        public int CantidadTotal { get; set; }

    }
}
