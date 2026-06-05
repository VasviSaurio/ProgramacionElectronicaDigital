using ProyectoGasolinera.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ProyectoGasolinera.CLASES.GestorArchivos;

namespace ProyectoGasolinera
{
    public partial class Form1 : Form

    {

        private SerialPort puertoSerial = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tabControl2.Appearance = TabAppearance.FlatButtons;
            //tabControl2.ItemSize = new Size(0, 1);
            //tabControl2.SizeMode = TabSizeMode.Fixed;
            //tabControl2.SelectedTab = tabBienvenida;
        }

        private void btnObtenerPuertosDisponibles_Click(object sender, EventArgs e)
        {
            btnCerrarPuerto.Enabled = false;
            string[] puertos = SerialPort.GetPortNames();
            cbPuertosDisponibles.Items.AddRange(puertos);
            cbPuertosDisponibles.SelectedIndex = 0;
        }

        private void btnConectarPuerto_Click(object sender, EventArgs e)
        {
            btnConectarPuerto.Enabled=false;
            btnCerrarPuerto.Enabled = true;

            try
            {
                puertoSerial.PortName = cbPuertosDisponibles.Text;
                puertoSerial.Open();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            /*
            try
            {
                if(puertoSerial.IsOpen){
                    puertoSerial.Write("MENSAJE");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (puertoSerial.IsOpen)
                {
                    string TXT = puertoSerial.ReadExisting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }

        private void btnCerrarPuerto_Click(object sender, EventArgs e)
        {
            btnConectarPuerto.Enabled = true;
            btnCerrarPuerto.Enabled = false;

            try
            {
                puertoSerial.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puertoSerial!= null && puertoSerial.IsOpen)
            {
                puertoSerial.Close();
            }
        }

        private void tabBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarAlInicio_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabBienvenida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabBienvenida;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabBienvenida;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabBienvenida;
        }

        private void btnRealizarPedidoGasolina_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabVentaGasolina;
        }

        private void btnAbastecimientoBombas_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabAbastecimientos;
        }

        private void btnReportesYCierres_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabSeleccionReportesYCierres;
        }

        private void btnVerReportesYCierres_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabReportes;
        }

        private void tabAbastecimientos_Click(object sender, EventArgs e)
        {

        }
    }
}
    
