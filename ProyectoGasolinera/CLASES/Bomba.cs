using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoGasolinera.CLASES
{
    public class Bomba
    {
        public int IdBomba { get; set; }
        public double LitrosSolicitados { get; set; }
        public double LitrosDespachados { get; set; }
        public string ConfiguracionBomba { get; set; }
        public TipoDespacho Tipo { get; set; }

        public enum TipoDespacho
        {
            Prepago,
            TanqueLleno
        }

        public Bomba()
        {
            IdBomba = 1;
            LitrosSolicitados = 0;
            LitrosDespachados = 0;
            ConfiguracionBomba = "PREPAGO";
            Tipo = TipoDespacho.Prepago;
        }

        public Bomba(int idBomba, double litrosSolicitados)
        {
            IdBomba = idBomba;
            LitrosSolicitados = litrosSolicitados;
            LitrosDespachados = 0;

            
            if (litrosSolicitados == -1)
            {
                ConfiguracionBomba = "TANQUE LLENO";
                Tipo = TipoDespacho.TanqueLleno;
            }
            else
            {
                ConfiguracionBomba = "PREPAGO";
                Tipo = TipoDespacho.Prepago;
            }
        }

        public void IniciarDespacho(SerialPort puerto, double precio)
        {
            try
            {
                if (puerto != null && puerto.IsOpen)
                {
                    
                    string mensaje = $"{{\"cmd\":\"activar\",\"bomba\":{IdBomba},\"litros\":{LitrosSolicitados.ToString(System.Globalization.CultureInfo.InvariantCulture)},\"precio\":{precio.ToString(System.Globalization.CultureInfo.InvariantCulture)}}}";
                    MessageBox.Show(mensaje);
                    
                    puerto.WriteLine(mensaje);
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto.", "Error de Comunicación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar comando: " + ex.Message);
            }
        }

        public void DetenerDespacho(SerialPort puerto)
        {
            try
            {
                if (puerto != null && puerto.IsOpen)
                {
                    string mensaje = $"{{\"cmd\":\"detener\",\"bomba\":{IdBomba}}}";
                    puerto.WriteLine(mensaje); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detener: " + ex.Message);
            }
        }
    }
}