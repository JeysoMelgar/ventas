using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var productosBL = new ProductoBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;

            var categoriasBL = new CategoriaBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;

            var clientesBL = new ClientesBL();
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;

            var ciudadBL = new CiudadBL();
            listadeCiudadesBindingSource.DataSource = ciudadBL.ListadeCiudades;
            
        }


    }
}
