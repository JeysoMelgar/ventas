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
using Ventas.Modelos;

namespace Ventas
{
    public partial class Form3 : Form
    {
        FacturaBL _facturaBL;
        public Form3()
        {
            InitializeComponent();
        }
        public void cargarDatos(FacturaBL facturaBL, ClientesBL clientesBL, ProductoBL productoBL)
        {
           
            listadeFacturasBindingSource.DataSource = facturaBL.ListadeFacturas;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeProductosBindingSource.DataSource = productoBL.ListadeProductos;
        }   

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularTotalFactura();

            listadeFacturasBindingSource.ResetBindings(false);
        }
    }
    
}
