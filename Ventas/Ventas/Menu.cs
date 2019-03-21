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
    public partial class Menu : Form
    {
        ProductoBL _productosBL;
        CategoriaBL _categoriasBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadBL;
        FacturaBL _facturaBL;
        ProveedoresBL _proveedorBL;
        ComprasBL _comprasBL;
        CostoBL _costosBL;
        public Menu()
        {
            InitializeComponent();
            _productosBL = new ProductoBL();
            _categoriasBL = new CategoriaBL();
            _clientesBL = new ClientesBL();
            _ciudadBL = new CiudadBL();
            _facturaBL = new FacturaBL();
            _proveedorBL = new ProveedoresBL();
            _comprasBL = new ComprasBL();
            _costosBL = new CostoBL();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();
            formProductos.MdiParent = this;
            formProductos.cargarDatos(_productosBL , _categoriasBL);
            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;
            formClientes.cargarDatos(_clientesBL, _ciudadBL);
            formClientes.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form3();
            formFactura.MdiParent = this;
            formFactura.cargarDatos(_facturaBL, _clientesBL, _productosBL);
            formFactura.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new Form4();
            formProveedores.MdiParent = this;
            formProveedores.cargarDatos(_proveedorBL, _ciudadBL);
            formProveedores.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
            formCompras.MdiParent = this;
            formCompras.cargarDatos(_comprasBL,_proveedorBL,_costosBL);
            formCompras.Show();
        }
    }
}
