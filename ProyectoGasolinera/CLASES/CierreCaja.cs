using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    public class CierreCaja
    {
        public DateTime FechaHoraCierre
        {
            get;
            set;
        }

        public double TotalCaja
        {
            get;
            set;
        }

        public List<Despacho> Despachos
        {
            get;
            set;
        }
    }
}
