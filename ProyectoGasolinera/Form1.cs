using ProyectoGasolinera.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoGasolinera.CLASES.GestorArchivos;

namespace ProyectoGasolinera
{
    public partial class Form1 : Form

    {
        private Central central;
        private List<Bomba> bombas;
        private Comunicacion comunicacion;
        public Form1()
        {
            InitializeComponent();

          
            central = new Central();
            bombas = new List<Bomba>
            {
                new Bomba(), // BOMBA1
                new Bomba()  // BOMBA2
               
            };
            comunicacion = new Comunicacion("COM3");

        
            central.PrecioSuper = 10.0;
            central.PrecioDiesel = 8.5;

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
    }
}
