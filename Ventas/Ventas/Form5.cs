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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public void cargarDatos(ComprasBL comprasBL, ProveedoresBL proveedorBL, CostoBL costoBL)
        {
            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            listadeProveedorBindingSource.DataSource = proveedorBL.ListadeProveedor;
            listadeCostosBindingSource.DataSource = costoBL.ListadeCostos;
        }
    }
}
