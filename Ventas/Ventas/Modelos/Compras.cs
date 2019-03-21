using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BL;

namespace Ventas.Modelos
{
    public class Compras
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public BindingList<ComprasDetalle> ComprasDetalle { get; set; }
        public Compras()
        {
            Fecha = DateTime.Now;   
            Activo = true;
            ComprasDetalle = new BindingList<ComprasDetalle>();
        }

        public void CalcularTotalCompras()
        {
            var costoBL = new CostoBL();
            double subtotal = 0;
            foreach (var detalle in ComprasDetalle)
            {
                var precio = costoBL.ObtenerPrecio(detalle.PrecioId);
                subtotal = subtotal + detalle.CalcularTotalDetalle(precio);
            }
            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15;
            Total = Subtotal + Impuesto;
        }
    }
    public class ComprasDetalle
    {

        public int Id { get; set; }
        public int CostoId { get; set; }
        public Costo Costo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public object PrecioId { get; internal set; }
        public double precio { get; private set; }

        public ComprasDetalle()
        {
            Cantidad = 1;
            CostoId = 1;
        }
        public double CalcularTotalDetalle(double costo)
        {
            Precio = precio;
            Total = Cantidad * Precio;
            return Total;
        }

        internal double CalcularTotalDetalle(object costo)
        {
            throw new NotImplementedException();
        }
    }
}
