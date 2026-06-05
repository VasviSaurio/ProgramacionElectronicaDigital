using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class Bomba
    {
        public bool Disponible { get; set; }
        public int TotalUsos { get; private set; }

        public Bomba()
        {
            Disponible = true;
            TotalUsos = 0;
        }

        public void IniciarAbastecimiento()
        {
            if (Disponible)
            {
                TotalUsos++;
                Console.WriteLine("Abastecimiento iniciado en la bomba.");
            }
            else
            {
                Console.WriteLine("La bomba no está disponible.");
            }
        }
    }
}
