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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();   
        }

        public void cargarDatos(ProveedoresBL proveedorBL, CiudadBL ciudadesBL)
        {

            
            listadeProveedorBindingSource.DataSource = proveedorBL.ListadeProveedor;
            listadeCiudadesBindingSource.DataSource = ciudadesBL.ListadeCiudades;
        }

        private void listadeCiudadesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
