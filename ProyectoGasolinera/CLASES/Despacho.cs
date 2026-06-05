using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGasolinera.CLASES
{
    internal class Despacho
    {
        public static List<Despacho> despachosDelDía = new List<Despacho>();

        private Cliente clienteSolicitado = new Cliente();
        private Bomba bombaSolicitada  = new Bomba();
        private double precioGasolina;

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
    }
}
