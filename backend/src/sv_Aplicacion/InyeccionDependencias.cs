using Microsoft.Extensions.DependencyInjection;
using sv_Aplicacion.IServicios;
using sv_Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace sv_Aplicacion
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarInfraestructura (this IServiceCollection servicios)
        {
            servicios.AddScoped<IProductoServicios, ProductoServicio>();

            return servicios;
        }
    }
}
