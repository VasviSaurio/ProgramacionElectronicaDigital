using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class Despachador
    {
        public string NombreDespachador { get; set; }
        public List<Bomba> Bombas { get; set; }

        public Despachador(string nombre)
        {
            NombreDespachador = nombre;
            Bombas = new List<Bomba>();
        }

        public void SolicitarServicio(Bomba bomba)
        {
            bomba.IniciarAbastecimiento();
            Console.WriteLine($"{NombreDespachador} solicitó servicio en la bomba.");
        }

        public void RealizarCobro(double monto)
        {
            Console.WriteLine($"{NombreDespachador} realizó el cobro de Q{monto}.");
        }
    }
}
