﻿using System;
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
    public partial class FormReportedeCompras : Form
    {
        public FormReportedeCompras()
        {
            InitializeComponent();
        }

        public void CargarDatos(ComprasBL comprasBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from c in comprasBL.ListadeCompras
                select new
                {
                    Id = c.Id,
                    Fecha = c.Fecha,
                    ProveedorId = c.ProveedorId,
                    Proveedor = c.Proveedor,
                    Subtotal = c.Subtotal,
                    Total = c.Total,
                    Activo = c.Activo,
                };
            var reporte = new ReportedeCompras();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
