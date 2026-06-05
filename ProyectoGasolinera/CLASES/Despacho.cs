using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class Despacho
    {
        //FORMATO 
        //{"cmd":"activar","bomba":1,"litros":5,"precio":10}
        //{"cmd":"activar","bomba":2,"litros":3,"precio":12}
        //{"cmd":"activar","bomba":1,"litros":-1,"precio":10}
        //{"cmd":"detener","bomba":1}
        //{"tipo":"estado","b1":1.25,"b2":0.73}
        public string NombreDespachador { get; set; }
        public List<Bomba> Bombas { get; set; }

        public Despacho(string nombre)
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
