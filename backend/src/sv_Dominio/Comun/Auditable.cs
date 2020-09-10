using System;
using System.Collections.Generic;
using System.Text;

namespace sv_Dominio.Comun
{
    public class Auditable
    {
        public string IdCreador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string IdModificador { get; set; }
    }
}
