using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sv_ClienteEscritorio
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            InyectarDependencias(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(new Vistas.AgregarProducto());
            }

        }

        public static void InyectarDependencias(IServiceCollection services)
        {
            sv_Aplicacion.InyeccionDependencias.AgregarInfraestructura(services);
        }
    }
}
