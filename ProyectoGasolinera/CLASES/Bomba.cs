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
        private int idBomba;
        private double litrosSolicitados;
        private double litrosDespachados;
        private double precioGasolina;

        public Bomba(int idBomba, double litrosSolicitados)
        {
            this.idBomba = idBomba;
            this.litrosSolicitados = litrosSolicitados;
            litrosDespachados = 0;
        }
        public Bomba()
        {
            idBomba = 1;
            litrosSolicitados = 0;
            litrosDespachados = 0;
            //TANQUE LLENO
            //PREPAGO
        }

        public int IdBomba { get => idBomba; set => idBomba = value; }
        public double LitrosDespachados { get => litrosDespachados; set => litrosDespachados = value; }
        public void setLitrosSolicitados(double lt)
        {
            litrosSolicitados = lt;
        }

        public void iniciarDespacho(SerialPort puerto, double precio)
        {
            try
            {
                if (puerto.IsOpen)
                {
                    string mensaje = $"{{\"cmd\":\"activar\",\"bomba\":{idBomba},\"litros\":{litrosSolicitados},\"precio\":{precio}}}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void detenerDespacho(SerialPort puerto)
        {
            try
            {
                if (puerto.IsOpen)
                {
                    string mensaje = $"{{\"cmd\":\"detener\",\"bomba\":{idBomba}}}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
