using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class Comunicacion
    {
        public string Puerto { get; set; }

        public Comunicacion(string puerto)
        {
            Puerto = puerto;
        }

        public void EnviarMensajeJSON(string mensaje)
        {
            Console.WriteLine($"Enviando mensaje JSON por {Puerto}: {mensaje}");
        }

        public string RecibirMensajeJSON()
        {
            string mensaje = "{ \"estado\": \"finalizado\" }";
            Console.WriteLine($"Recibiendo mensaje JSON por {Puerto}: {mensaje}");
            return mensaje;
        }
    }
