﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sv_WebApi.ModelosVistas.Productos
{
    public class ProductoCrear
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadComprada { get; set; }
    }
}