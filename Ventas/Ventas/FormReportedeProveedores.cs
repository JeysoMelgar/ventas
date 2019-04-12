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
    public partial class FormReportedeProveedores : Form
    {
        public FormReportedeProveedores()
        {
            InitializeComponent();
        }

        public void CargarDatos (ProveedoresBL proveedoresBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from p in proveedoresBL.ListadeProveedor
                select new
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    CiudadId = p.CiudadId,
                    Telefono = p.Telefono,
                    Ciudad = p.Ciudad.Descripcion,
                    Cargo = p.Cargo,
                };

            var reporte = new ReportedeProveedores();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
