using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sv_Aplicacion.IRepositorios;
using sv_Infraestructura.Modelos;
using sv_Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace sv_Infraestructura
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarInfraestructura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<sv_senaContext>(opciones =>
            {
                if (configuration.GetValue<string>("DBProvider") == "mysql")
                    opciones.UseMySql(configuration.GetConnectionString("sv_mysql"));
            });

            services.AddScoped<IProductoRepositorio, ProductoRepositorio>();        

            return services;
        }
    }
}
