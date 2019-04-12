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
    public partial class FormReportedeClientes : Form
    {
        public FormReportedeClientes()
        {
            InitializeComponent();
        }

        public void CargarDatos(ClientesBL clientesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from c in clientesBL.ListadeClientes
                select new
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    CiudadId = c.CiudadId,
                    Telefono = c.Telefono,
                    Ciudad = c.Ciudad.Descripcion,
                };
            var reporte = new ReportedeClientes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
