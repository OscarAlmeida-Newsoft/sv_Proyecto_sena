using sv_ClienteEscritorio.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sv_ClienteEscritorio.Vistas
{
    public partial class AgregarProducto : Form
    {

        private ProductoControlador controlador = new ProductoControlador();

        public AgregarProducto()
        {
            InitializeComponent();
            LlenarTabla();
        }

        public async Task LlenarTabla()
        {
            var prods = await controlador.ObtenerProductos();
            tablaProductos.DataSource = prods;
        }
    }
}
