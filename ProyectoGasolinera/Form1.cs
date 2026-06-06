using ProyectoGasolinera.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoGasolinera
{
    public partial class Form1 : Form
    {
        private CLASES.Central central = new CLASES.Central();
        private string rutaRaiz;
        double precioGasolina = 0;
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

            rutaRaiz = Application.StartupPath;
            try
            {
                string precio = File.ReadAllText(Path.Combine(rutaRaiz, "Precio.txt"));
                precioGasolina = Convert.ToDouble(precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                precioGasolina = 8.64;
            }

            txtPrecioGasolinaDeHoy.Text = precioGasolina.ToString();
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

        private void ProcesarDatosArduino(string json)
        {
            try
            {

            }catch (Exception ex)
            {
                

            }
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
            tablaAbastecimientosActuales.DataSource = null;
            tablaAbastecimientosActuales.DataSource = CLASES.Despacho.despachosDelDía;
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
            if ((checkBoxCF.Checked || (txtNitCliente.TextLength > 0 && txtNombreCliente.TextLength > 0))
        && cbBombasDisponibles.SelectedIndex > -1
        && cbTipoAbstecimiento.SelectedIndex > -1
        && txtCantidadLitrosGasolina.TextLength > 0)
            {
                try
                {
                    CLASES.Cliente clienteNuevo;
                    if (checkBoxCF.Checked)
                    {
                        
                        clienteNuevo = new CLASES.Cliente();
                    }
                    else
                    {
                        clienteNuevo = new CLASES.Cliente(txtNombreCliente.Text, txtNitCliente.Text);
                    }

                    
                    int idBomba = cbBombasDisponibles.SelectedIndex + 1;

                   
                    double litrosSolicitados = Convert.ToDouble(txtCantidadLitrosGasolina.Text);


                    
                    CLASES.Bomba bombaNueva = new CLASES.Bomba(idBomba, litrosSolicitados);
                    CLASES.Despacho despachoNuevo = new CLASES.Despacho(clienteNuevo, bombaNueva, precioGasolina);

                    central.AgregarDespacho(despachoNuevo);

                    //bombaNueva.IniciarDespacho(puertoSerial, precioGasolina);
                   btnIniciarDespachoBomba1.Enabled = true;

                    MessageBox.Show($"¡Despacho iniciado en la Bomba {idBomba}!\nModalidad: {bombaNueva.ConfiguracionBomba}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al procesar la solicitud: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los datos obligatorios antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void ActualizarInterfazBombas(System.Text.Json.JsonElement root)
        {
            try
            {
                double b1 = root.GetProperty("b1").GetDouble();
                double b2 = root.GetProperty("b2").GetDouble();

                
                central.ActualizarLitrosBomba(1, b1);
                central.ActualizarLitrosBomba(2, b2);

                this.Invoke((MethodInvoker)delegate
                {
                    txtProgresoLitrosBomba1.Text = b1.ToString("0.00");
                    txtProgresoMontoBomba1.Text = (b1 * precioGasolina).ToString("0.00");
                    txtProgresoLitrosBomba2.Text = b2.ToString("0.00");
                    txtProgresoMontoBomba2.Text = (b2 * precioGasolina).ToString("0.00");

                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("🔥 ERROR AL ACTUALIZAR UI: " + ex.Message);
            }
        }
        private void EnrutarJsonArduino(string json)
        {
            try
            {
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    JsonElement root = doc.RootElement;
                    string tipo = root.GetProperty("tipo").GetString();

                    if (tipo == "estado")
                    {
                        ActualizarInterfazBombas(root);
                    }
                    else if (tipo == "fin")
                    {
                        btnRealizarCobroBomba1.Enabled = true;
                        btnRealizarCobroBomba2.Enabled = true;
                    }
                }
            }
            catch (JsonException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enrutando datos: " + ex.Message, "Error Interno");
            }
        }
        private void puertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string jsonRecibido = puertoSerial.ReadExisting();

                
                this.Invoke((MethodInvoker)delegate
                {
                    listaDespachosBomba1.Items.Add(jsonRecibido);
                    EnrutarJsonArduino(jsonRecibido);
                });
            }
            catch (Exception)
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPrecioGasolinaDeHoy.TextLength != 0)
            {
                try
                {
                    string rutaArchivo = Path.Combine(rutaRaiz, "Precio.txt");

                    
                    File.WriteAllText(rutaArchivo, txtPrecioGasolinaDeHoy.Text);

                    precioGasolina = Convert.ToDouble(txtPrecioGasolinaDeHoy.Text);

                    MessageBox.Show("Precio actualizado a: Q" + precioGasolina, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fatal al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo de precio no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIniciarDespachoBomba1_Click(object sender, EventArgs e)
        {
            var despachoActivo = central.DespachosActivos.FirstOrDefault(d => d.BombaSolicitada.IdBomba == 1);

            if (despachoActivo != null)
            {
                
                txtIdDespachoBomba1.Text = despachoActivo.getIdDespacho();

                despachoActivo.BombaSolicitada.IniciarDespacho(puertoSerial, precioGasolina);

                
            }
            else
            {
                MessageBox.Show("No hay ningún despacho asignado a la Bomba 1 en este momento.", "Bomba Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetenerDespachoBomba1_Click(object sender, EventArgs e)
        {
            var despachoActivo = central.DespachosActivos.FirstOrDefault(d => d.BombaSolicitada.IdBomba == 1);

            if (despachoActivo != null)
            {
                
                despachoActivo.BombaSolicitada.DetenerDespacho(puertoSerial);

               
                btnIniciarDespachoBomba2.Enabled = true;
                btnDetenerDespachoBomba2.Enabled = false;
            }
            else
            {
                MessageBox.Show("La bomba ya está detenida o no tiene un despacho activo.", "Acción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRealizarCobroBomba1_Click(object sender, EventArgs e)
        {
            var despachoActivo = central.DespachosActivos.FirstOrDefault(d => d.BombaSolicitada.IdBomba == 1);

            if (despachoActivo != null)
            {
                
                double totalAPagar = despachoActivo.BombaSolicitada.LitrosDespachados * precioGasolina;

                
                MessageBox.Show($"Cobro realizado con éxito.\nTotal a pagar: Q{totalAPagar:0.00}",
                                "Cierre de Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                central.FinalizarDespacho(despachoActivo);

                txtProgresoLitrosBomba1.Clear();
                txtProgresoMontoBomba1.Clear();
                txtIdDespachoBomba1.Clear();

                //btnIniciarBomba1.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay un despacho pendiente de cobro en esta bomba.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (CLASES.Despacho.despachosDelDía.Count == 0)
            {
                MessageBox.Show("No hay despachos para cerrar.");
                return;
            }

            string nombreArchivo = $"Corte_{DateTime.Now:yyyyMMdd_HHmm}.txt";
            string rutaArchivo = Path.Combine(rutaRaiz, nombreArchivo);

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    sw.WriteLine("--- REPORTE DE CIERRE DE CAJA ---");
                    sw.WriteLine($"Fecha: {DateTime.Now}");
                    sw.WriteLine("ID | Bomba | Litros | Total Q.");

                    double totalDia = 0;
                    foreach (var d in CLASES.Despacho.despachosDelDía)
                    {
                        sw.WriteLine($"{d.getIdDespacho()} | {d.BombaSolicitada.IdBomba} | {d.BombaSolicitada.LitrosDespachados} | Q.{d.CantidadCobrada}");
                        totalDia += d.CantidadCobrada;
                    }
                    sw.WriteLine("---------------------------------");
                    sw.WriteLine($"TOTAL RECAUDADO: Q{totalDia:0.00}");
                }

                CLASES.Despacho.despachosDelDía.Clear();
                tablaAbastecimientosActuales.DataSource = null;

                MessageBox.Show($"Caja cerrada exitosamente. Reporte guardado en: {nombreArchivo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar caja: " + ex.Message);
            }
        }
    }
}
    
