using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoGasolinera.CLASES;
using static ProyectoGasolinera.CLASES.GestorArchivos;

namespace ProyectoGasolinera
{
    public partial class Form1 : Form

    {
        private Central central;
        private List<Bomba> bombas;
        private Comunicacion comunicacion;
        private string tipoServicioSeleccionado = "Prepago"; 
   

        public Form1()
        {
            InitializeComponent();

            central = new Central();
            bombas = new List<Bomba>
            {
                new Bomba(), // BOMBA1
                new Bomba(), // BOMBA2
                new Bomba(), // BOMBA3
                new Bomba(), // BOMBA4
            };
            comunicacion = new Comunicacion("COM3");

            central.PrecioSuper = 10.0;
            central.PrecioDiesel = 8.5;
            //comunicacionSerial = new ComunicacionSerial("COM3", 9600);
            //comunicacionSerial.MensajeRecibido += ProcesarRespuestaArduino;
            //comunicacionSerial.Abrir();

        }
        private void ProcesarRespuestaArduino(string mensaje)
        {
            
            MessageBox.Show("Respuesta Arduino: " + mensaje);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = "{ \"accion\": \"iniciar\", \"bomba\": 1, \"litros\": 2.5 }";
            //comunicacionSerial.Enviar(mensaje);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcesarAbastecimiento(0, "Bomba 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcesarAbastecimiento(1, "Bomba 2");
        }
        private void ProcesarAbastecimiento(int indiceBomba, string nombreBomba)
        {
            string cliente = txtNombreCliente.Text;
            string nit = txtNIT.Text;
            double monto = double.Parse(txtMonto.Text);

            Bomba bombaSeleccionada = bombas[indiceBomba];
            bombaSeleccionada.IniciarAbastecimiento();

            double litros = monto / central.PrecioSuper;

            central.Facturar(cliente, monto);

          
            var registro = new RegistroAbastecimiento
            {
                Fecha = DateTime.Now,
                Cliente = cliente,
                NIT = nit,
                Monto = monto,
                Litros = litros,
                Bomba = nombreBomba,
                TipoServicio = "Prepago"
            };

          
            GestorArchivos.GuardarRegistro(registro);

           
            dgvHistorial.Rows.Add(registro.Fecha, registro.Cliente, registro.NIT, registro.Monto, registro.Litros, registro.Bomba);

           
            string mensaje = System.Text.Json.JsonSerializer.Serialize(new
            {
                accion = "iniciar",
                bomba = indiceBomba + 1,
                litros = litros
            });
            comunicacion.EnviarMensajeJSON(mensaje);
        }

       
        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            central.GenerarCierreCaja();
            MessageBox.Show("Cierre de caja generado en consola.");
        }
    }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tipoServicioSeleccionado = "Prepago";
            MessageBox.Show("Modo Prepago seleccionado.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipoServicioSeleccionado = "Tanque lleno";
            MessageBox.Show("Modo Tanque lleno seleccionado.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cliente = txtNombreCliente.Text;
            string nit = txtNIT.Text;
            double monto = 0;
            double litros = 0;

            // Seleccionamos la primera bomba como ejemplo
            Bomba bombaSeleccionada = bombas[0];
            bombaSeleccionada.IniciarAbastecimiento();

            if (tipoServicioSeleccionado == "Prepago")
            {
                monto = double.Parse(txtMonto.Text);
                litros = monto / central.PrecioSuper;
            }
            else if (tipoServicioSeleccionado == "Tanque lleno")
            {
                // Simulación: tanque lleno abastece 40 litros
                litros = 40;
                monto = litros * central.PrecioSuper;
            }

            // Facturar
            central.Facturar(cliente, monto);

            // Crear registro
            var registro = new RegistroAbastecimiento
            {
                Fecha = DateTime.Now,
                Cliente = cliente,
                NIT = nit,
                Monto = monto,
                Litros = litros,
                Bomba = "Bomba 1",
                TipoServicio = tipoServicioSeleccionado
            };

            // Guardar en archivo JSON
            GestorArchivos.GuardarRegistro(registro);

            // Mostrar en DataGridView
            dgvHistorial.Rows.Add(registro.Fecha, registro.Cliente, registro.NIT, registro.Monto, registro.Litros, registro.Bomba, registro.TipoServicio);

            // Comunicación con Arduino
            string mensaje = System.Text.Json.JsonSerializer.Serialize(new
            {
                accion = "iniciar",
                bomba = 1,
                litros = litros,
                tipo = tipoServicioSeleccionado
            });
            comunicacion.EnviarMensajeJSON(mensaje);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                // Generar cierre de caja del día
                central.GenerarCierreCaja();

                // Mostrar en un MessageBox
                MessageBox.Show("Cierre de caja generado. Revisa consola o archivo.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Leer registros desde archivo JSON
            List<RegistroAbastecimiento> registros = GestorArchivos.LeerRegistros();

            if (registros.Count == 0)
            {
                MessageBox.Show("No hay registros previos.");
                return;
            }

            // Agrupar por fecha (día)
            var cierres = registros
                .GroupBy(r => r.Fecha.Date)
                .Select(g => new
                {
                    Fecha = g.Key,
                    TotalDia = g.Sum(r => r.Monto),
                    Abastecimientos = g.Count()
                });

            // Mostrar resultados en consola y DataGridView
            //dgvCierres.Rows.Clear();
            foreach (var cierre in cierres)
            {
                //dgvCierres.Rows.Add(cierre.Fecha, cierre.Abastecimientos, cierre.TotalDia);
                Console.WriteLine($"Fecha: {cierre.Fecha} | Abastecimientos: {cierre.Abastecimientos} | Total: Q{cierre.TotalDia}");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<RegistroAbastecimiento> registros = GestorArchivos.LeerRegistros();

            if (registros.Count == 0)
            {
                MessageBox.Show("No hay registros para estadísticas.");
                return;
            }

            // Filtrar por día actual
            var hoy = DateTime.Now.Date;
            var abastecimientosHoy = registros.Where(r => r.Fecha.Date == hoy).ToList();

            dgvAbastecimientosHoy.Rows.Clear();
            foreach (var r in abastecimientosHoy)
            {
                dgvAbastecimientosHoy.Rows.Add(r.Fecha, r.Cliente, r.NIT, r.Monto, r.Litros, r.Bomba, r.TipoServicio);
            }

            // Estadísticas de Prepago y Tanque lleno
            int totalPrepago = registros.Count(r => r.TipoServicio == "Prepago");
            int totalTanqueLleno = registros.Count(r => r.TipoServicio == "Tanque lleno");

            lblPrepago.Text = $"Total Prepago: {totalPrepago}";
            lblTanqueLleno.Text = $"Total Tanque lleno: {totalTanqueLleno}";

            // Uso de bombas
            var usoBombas = registros.GroupBy(r => r.Bomba)
                                     .Select(g => new { Bomba = g.Key, Usos = g.Count() })
                                     .ToList();

            chartUsoBombas.Series.Clear();
            var serie = new Series("Series1");
            serie.ChartType = SeriesChartType.Column;

            foreach (var b in usoBombas)
            {
                serie.Points.AddXY(b.Bomba, b.Usos);
            }

            chartUsoBombas.Series.Add(serie);

            // Bomba más usada y menos usada
            var bombaMasUsada = usoBombas.OrderByDescending(b => b.Usos).FirstOrDefault();
            var bombaMenosUsada = usoBombas.OrderBy(b => b.Usos).FirstOrDefault();

            lblBombaMasUsada.Text = $"Bomba más usada: {bombaMasUsada?.Bomba ?? "N/A"}";
            lblBombaMenosUsada.Text = $"Bomba menos usada: {bombaMenosUsada?.Bomba ?? "N/A"}";
        }
    }
    }
    
