using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProveedoresBL
    {
        public List<Proveedor> ListadeProveedor { get; set; }

        public ProveedoresBL()
        {
            ListadeProveedor = new List<Proveedor>();
            CrearListadePrueba();
        }

        private void CrearListadePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            var proveedor1 = new Proveedor(1, "Ramon", 97542270, ciudad1,"Gerente de Manufactura");
            var proveedor2 = new Proveedor(2, "Carlos", 98079895, ciudad1,"Gerente de Produccion");
            var proveedor3 = new Proveedor(3, "Juan", 99394562, ciudad2,"Gerente Industrial");

            ListadeProveedor.Add(proveedor1);
            ListadeProveedor.Add(proveedor2);
            ListadeProveedor.Add(proveedor3);
        }
    }
}
