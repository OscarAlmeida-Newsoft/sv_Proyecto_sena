using sv_Dominio.Comun;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sv_Dominio.Entidades
{
    public class Producto: Auditable
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioVentaActual { get; set; }
        public int CantidadTotal { get; set; }
    }
}
