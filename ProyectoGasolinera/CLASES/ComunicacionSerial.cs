using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class ComunicacionSerial
    {
        private SerialPort serialPort;

        public event Action<string> MensajeRecibido;

        public ComunicacionSerial(string puerto, int baudRate = 9600)
        {
            serialPort = new SerialPort(puerto, baudRate);
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        // Abrir conexión
        public void Abrir()
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
                Console.WriteLine($"Puerto {serialPort.PortName} abierto.");
            }
        }

        // Cerrar conexión
        public void Cerrar()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Console.WriteLine($"Puerto {serialPort.PortName} cerrado.");
            }
        }

        // Enviar mensaje JSON al Arduino
        public void Enviar(string mensaje)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(mensaje);
                Console.WriteLine($"Enviado: {mensaje}");
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }
        }

        // Evento: recibir datos del Arduino
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                Console.WriteLine($"Recibido: {data}");

                // Disparar evento para que el Form pueda manejarlo
                MensajeRecibido?.Invoke(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recibir datos: " + ex.Message);
            }
        }
    }
}
