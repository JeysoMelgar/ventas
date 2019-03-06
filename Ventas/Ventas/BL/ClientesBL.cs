using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearListadePrueba();
        }

        private void CrearListadePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            var cliente1 = new Cliente(1, "Mario", 97542270, ciudad1);
            var cliente2 = new Cliente(2, "Leonel", 98079895, ciudad1);
            var cliente3 = new Cliente(3, "Pedro", 99394562, ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
