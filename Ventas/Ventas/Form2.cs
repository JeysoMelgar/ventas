using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ciudad
            var ciudad1 = new Ciudad();
            ciudad1.Id = 0501;
            ciudad1.Descripcion = "San Pedro Sula";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 0150;
            ciudad2.Descripcion = "Santa Barbara";

            var ciudad3 = new Ciudad();
            ciudad3.Id = 0305;
            ciudad3.Descripcion = "Santa Rosa de Copan";

            // Clientes
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Brandon Melgar";
            cliente1.Descripcion = "Niño Joven";
            cliente1.Ciudad = ciudad1;

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Jeisson Serrano";
            cliente2.Descripcion = "Joven Adulto";
            cliente2.Ciudad = ciudad2;

            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Juan Mejia";
            cliente3.Descripcion = " Adulto Mayor";
            cliente3.Ciudad = ciudad3;

            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);

            foreach (var c in listadeClientes)
            {
                MessageBox.Show(c.Nombre + " " + c.Ciudad.Descripcion);
            }

        }
    }
}
