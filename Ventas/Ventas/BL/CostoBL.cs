using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;
namespace Ventas.BL
{
    public class CostoBL
    {
        public BindingList<Costo> ListadeCostos { get; set; }
        public CostoBL()
        {
            ListadeCostos = new BindingList<Costo>();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;
            foreach (var costo in ListadeCostos)
            {
                if (costo.Id == id)
                {
                    precio = costo.Precio;
                }
            }
            return precio;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var costo1 = new Costo(1, "Laptop Dell", 7000, categoria1);
            var costo2 = new Costo(2, "Laptop Asus", 13500, categoria1);
            var costo3 = new Costo(3, "Mouse Logitech", 16000, categoria2);

            ListadeCostos.Add(costo1);
            ListadeCostos.Add(costo2);
            ListadeCostos.Add(costo3);
        }

        internal object ObtenerPrecio(object precioId)
        {
            throw new NotImplementedException();
        }
    }
}
