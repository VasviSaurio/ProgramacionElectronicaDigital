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
            btnAbastecimientoBombas.Enabled = false;
            btnRealizarPedidoGasolina.Enabled = false;
            btnReportesYCierres.Enabled = false;
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
                puertoSerial = new SerialPort();
                puertoSerial.PortName = cbPuertosDisponibles.Text;
                puertoSerial.Open();

                btnAbastecimientoBombas.Enabled = true;
                btnRealizarPedidoGasolina.Enabled = true;
                btnReportesYCierres.Enabled = true;
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
                btnAbastecimientoBombas.Enabled = false;
                btnRealizarPedidoGasolina.Enabled = false;
                btnReportesYCierres.Enabled = false;
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

        private void txtCantidadLitrosGasolina_Enter(object sender, EventArgs e)
        {
            if (txtCantidadLitrosGasolina.TextLength > 0)
            {
                double cantidadLitros = Convert.ToDouble(txtCantidadLitrosGasolina.Text);
                double precioGasolina = Convert.ToDouble(txtPrecioGasolinaDeHoy.Text);
                txtCantidadEfectivoPorCobrar.Text = Math.Round((cantidadLitros * precioGasolina), 2).ToString();
            }
                
        }

        private void txtCantidadEfectivoPorCobrar_Enter(object sender, EventArgs e)
        {
            if (txtCantidadLitrosGasolina.TextLength >0)
            {
                double cantidadMonto = Convert.ToDouble(txtCantidadEfectivoPorCobrar.Text);
                double precioGasolina = Convert.ToDouble(txtPrecioGasolinaDeHoy.Text);
                txtCantidadLitrosGasolina.Text = Math.Round((cantidadMonto / precioGasolina), 2).ToString();
            }
            
        }

        private void txtCantidadLitrosGasolina_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidadEfectivoPorCobrar_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCantidadEfectivoPorCobrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCantidadEfectivoPorCobrar.TextLength > 0)
                {
                    double cantidadMonto = Convert.ToDouble(txtCantidadEfectivoPorCobrar.Text);
                    double precioGasolina = Convert.ToDouble(txtPrecioGasolinaDeHoy.Text);
                    txtCantidadLitrosGasolina.Text = Math.Round((cantidadMonto / precioGasolina), 2).ToString();
                }
            }
        }

        private void txtCantidadLitrosGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCantidadLitrosGasolina.TextLength > 0)
                {
                    double cantidadLitros = Convert.ToDouble(txtCantidadLitrosGasolina.Text);
                    double precioGasolina = Convert.ToDouble(txtPrecioGasolinaDeHoy.Text);
                    txtCantidadEfectivoPorCobrar.Text = Math.Round((cantidadLitros * precioGasolina), 2).ToString();
                }
            }
        }

        private void btnSolicitarDespacho_Click(object sender, EventArgs e)
        {
            if ((checkBoxCF.Checked || (txtNitCliente.TextLength > 0 && txtNombreCliente.TextLength > 0)) && cbBombasDisponibles.SelectedIndex>-1 && cbTipoAbstecimiento.SelectedIndex>-1 && txtCantidadLitrosGasolina.TextLength>0)
            {
                string nitCliente = txtNitCliente.Text;
                string nombreCLiente = txtNombreCliente.Text;
                string bombaElegida = cbBombasDisponibles.SelectedItem.ToString();
                string tipoAbastecimiento = cbTipoAbstecimiento.SelectedItem.ToString();
                string cantidadLitros = txtCantidadLitrosGasolina.Text;

                MessageBox.Show(
                $"NIT Cliente: {nitCliente}\n" +
                $"Nombre Cliente: {nombreCLiente}\n" +
                $"Bomba Elegida: {bombaElegida}\n" +
                $"Tipo de Abastecimiento: {tipoAbastecimiento}\n" +
                $"Cantidad de Litros: {cantidadLitros}",
                "Datos ingresados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );


                string linea = $"NIT: {nitCliente} | Cliente: {nombreCLiente} | Bomba: {bombaElegida} | Tipo: {tipoAbastecimiento} | Litros: {cantidadLitros}";

                Cliente cliente = new Cliente(nombreCLiente, nitCliente);





            }
            else
            {
                MessageBox.Show("Rellene los datos");

            }
        }

        private void checkBoxCF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCF.Checked)
            {
                txtNombreCliente.Text = "N/A";
                txtNitCliente.Text = "CF";
                txtNitCliente.Enabled = false;
                txtNombreCliente.Enabled = false;
            }
            else
            {
                txtNitCliente.Enabled = true;
                txtNombreCliente.Enabled = true;
            }
        }

        private void cbTipoAbstecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoAbstecimiento.SelectedIndex == 0)
            {
                txtCantidadLitrosGasolina.Text = "-1";
                txtCantidadEfectivoPorCobrar.Text = "0";
                txtCantidadLitrosGasolina.Enabled = false;
                txtCantidadEfectivoPorCobrar.Enabled = false;

            }
            else
            {
                txtCantidadLitrosGasolina.Text = "00";
                txtCantidadEfectivoPorCobrar.Text = "00";
                txtCantidadLitrosGasolina.Enabled = true;
                txtCantidadEfectivoPorCobrar.Enabled = true;
            }
        }
    }
}
    
