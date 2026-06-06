using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace ProyectoGasolinera.CLASES
{
    public class Central
    {
        public List<Despacho> DespachosActivos { get; set; }

        public List<CierreCaja> CierresCaja { get; set; }

        private string RutaCierres;
        public Central()
        {
            DespachosActivos = new List<Despacho>();

            CierresCaja = CargarCierres();
            RutaCierres = Path.Combine(Application.StartupPath,"cierres.json");
        }


        public void AgregarDespacho(
            Despacho despacho)
        {
            DespachosActivos.Add(despacho);
        }

        public void FinalizarDespacho(
            Despacho despacho)
        {
            despacho.despachoFinalizado();
        }


        public void ActualizarLitrosBomba(
            int idBomba,
            double litros)
        {
            foreach (var despacho in DespachosActivos)
            {
                if (despacho.BombaSolicitada.IdBomba == idBomba)
                {
                    despacho.BombaSolicitada.LitrosDespachados =
                        litros;

                    break;
                }
            }
        }

        public void RealizarCierreCaja()
        {
            CierreCaja cierre =
                new CierreCaja();

            cierre.FechaHoraCierre =
                DateTime.Now;

            cierre.Despachos =
                new List<Despacho>(
                    Despacho.despachosDelDía);

            cierre.TotalCaja =
                cierre.Despachos
                .Sum(x => x.CantidadCobrada);

            CierresCaja.Add(cierre);

            GuardarCierres();

            Despacho.despachosDelDía.Clear();
        }

        private IEnumerable<Despacho> ObtenerTodosLosDespachosHistoricos()
        {
            return CierresCaja.SelectMany(c => c.Despachos).Concat(Despacho.despachosDelDía);
        }

        public int ObtenerBombaMasUsada()
        {
            var despachos = ObtenerTodosLosDespachosHistoricos();
            if (!despachos.Any()) return 0; 

            return despachos
                .GroupBy(d => d.BombaSolicitada.IdBomba)
                .OrderByDescending(g => g.Count())
                .First().Key;
        }

        public int ObtenerBombaMenosUsada()
        {
            return 2;
        }

        public int ObtenerBombaMasUsadaPrepago()
        {
            return 1;
        }

        public int ObtenerBombaMasUsadaTanqueLleno()
        {
            return 1;
        }

        public double TotalVentas()
        {
            return CierresCaja
                .SelectMany(x => x.Despachos)
                .Sum(x =>
                    x.CantidadCobrada);
        }


        private void GuardarCierres()
        {
            string json =
                JsonSerializer.Serialize(
                    CierresCaja,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

            File.WriteAllText(
                RutaCierres,
                json);
        }

        private List<CierreCaja>
            CargarCierres()
        {
            if (!File.Exists(RutaCierres))
            {
                return new List<CierreCaja>();
            }

            string json =
                File.ReadAllText(
                    RutaCierres);

            return JsonSerializer.Deserialize
                <List<CierreCaja>>(json);
        }
    }
}
