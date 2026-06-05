using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class Central
    {
        public List<string> FacturasDelDia { get; private set; }
        public double TotalCaja { get; private set; }
        public double PrecioSuper { get; set; }
        public double PrecioDiesel { get; set; }

        public Central()
        {
            FacturasDelDia = new List<string>();
            TotalCaja = 0;
        }

        public void Facturar(string cliente, double monto)
        {
            string factura = $"{DateTime.Now} - Cliente: {cliente} - Monto: Q{monto}";
            FacturasDelDia.Add(factura);
            TotalCaja += monto;
            Console.WriteLine("Factura generada: " + factura);
        }

        public void GenerarCierreCaja()
        {
            Console.WriteLine("Cierre de caja del día:");
            foreach (var factura in FacturasDelDia)
            {
                Console.WriteLine(factura);
            }
            Console.WriteLine($"Total en caja: Q{TotalCaja}");
        }

        public void GenerarEstadisticas()
        {
            Console.WriteLine("Generando estadísticas...");
            // Aquí se implementarán estadísticas como bomba más usada, etc.
        }

        public void ActualizarValorGasolina(double nuevoPrecioSuper, double nuevoPrecioDiesel)
        {
            PrecioSuper = nuevoPrecioSuper;
            PrecioDiesel = nuevoPrecioDiesel;
            Console.WriteLine("Precios actualizados.");
        }
    }
}
