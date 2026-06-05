using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGasolinera.CLASES
{
    public class Despacho
    {
        public static List<Despacho> despachosDelDía = new List<Despacho>();
        private DateTime fechaYHoraActual = DateTime.Now;

        private Cliente clienteSolicitado = new Cliente();
        private Bomba bombaSolicitada  = new Bomba();
        private double precioGasolina;
        private double cantidadCobrada;

        public Despacho()
        {

        }
        public Despacho(Cliente cliente, Bomba bomba, double precioGasolina )
        {
            clienteSolicitado = cliente;
            bombaSolicitada = bomba;
            this.precioGasolina = precioGasolina;
        }

        public Cliente ClienteSolicitado { get => clienteSolicitado; set => clienteSolicitado = value; }
        public Bomba BombaSolicitada { get => bombaSolicitada; set => bombaSolicitada = value; }
        public double PrecioGasolina { get => precioGasolina; set => precioGasolina = value; }
        public double CantidadCobrada { get => cantidadCobrada; set => cantidadCobrada = value; }

        public void despachoFinalizado()
        {
            fechaYHoraActual = DateTime.Now;
            CantidadCobrada = precioGasolina * bombaSolicitada.LitrosDespachados;
            despachosDelDía.Add(this);
        }
    }
}
