using System;
using System.Collections.Generic;

namespace sv_Infraestructura.Modelos
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioVentaActual { get; set; }
        public int CantidadTotal { get; set; }
        public string IdCreador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string IdModificador { get; set; }
    }
}
