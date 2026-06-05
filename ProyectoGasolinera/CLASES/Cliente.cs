using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string NIT { get; set; }
        public Cliente(string nombre, string nit) {
            Nombre = nombre;
            NIT = nit;
        }
        public Cliente() {
            Nombre = "N/A";
            NIT = "CF";
        }
    }
}
