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
        private string tipoAbastecimiento;
        private double litrosDespachados;

        public Bomba(int idBomba, double litrosSolicitados, string tipoAbastecimiento)
        {
            this.idBomba = idBomba;
            this.litrosSolicitados = litrosSolicitados;
            this.tipoAbastecimiento = tipoAbastecimiento;
            litrosDespachados = 0;
        }
        public Bomba()
        {
            idBomba = 1;
            litrosSolicitados = 0;
            litrosDespachados = 0;
            //TANQUE LLENO
            //PREPAGO
            tipoAbastecimiento = "TANQUE LLENO";
        }

        public int IdBomba { get => idBomba; set => idBomba = value; }
        public double LitrosSolicitados { get => litrosSolicitados; set => litrosSolicitados = value; }
        public string TipoAbastecimiento { get => tipoAbastecimiento; set => tipoAbastecimiento = value; }
        public double LitrosDespachados { get => litrosDespachados; set => litrosDespachados = value; }

        public void iniciarDespacho(SerialPort puerto)
        {
            try
            {
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("MENSAJE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
