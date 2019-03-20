using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CiudadId { get; set; }
        public double Telefono { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Cargo { get; set; }

        public Proveedor()
        {
            Ciudad = new Ciudad(1, "San Pedro Sula");
            CiudadId = Ciudad.Id;
        }

        public Proveedor(int id, string nombre, double telefono, Ciudad ciudad,string cargo)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
            CiudadId = ciudad.Id;
            Cargo = cargo;
        }
    }

}
