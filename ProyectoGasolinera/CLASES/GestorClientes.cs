using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGasolinera.CLASES
{
    internal class GestorClientes
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static Cliente BuscarPorNIT(string nit)
        {
            return clientes.FirstOrDefault(c => c.NIT == nit);

        }
    }
}