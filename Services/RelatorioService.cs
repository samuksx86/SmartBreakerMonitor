using SmartBreaker.Models;
using SmartBreaker.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBreaker.Services
{
    public class RelatorioService
    {
        private readonly RegistroService _registroService;

        public RelatorioService(RegistroService registroService)
        {
            _registroService = registroService;
        }

        public void ExibirRelatorioFalhas()
        {
            var eventos = _registroService.ObterEventos();
            var falhasPorCircuito = eventos.OfType<Falha>()
                .GroupBy(f => f.Circuito)
                .Select(g => new { Circuito = g.Key, Qtd = g.Count() });

            Console.WriteLine("=== Relatório de Falhas por Circuito ===");
            foreach (var item in falhasPorCircuito)
                Console.WriteLine($"{item.Circuito}: {item.Qtd} falhas");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void ExibirRelatorioAlertas()
        {
            var eventos = _registroService.ObterEventos();
            var alertasPorCircuito = eventos.OfType<Alerta>()
                .GroupBy(a => a.Circuito)
                .Select(g => new { Circuito = g.Key, Qtd = g.Count() });

            Console.WriteLine("=== Relatório de Alertas por Circuito ===");
            foreach (var item in alertasPorCircuito)
                Console.WriteLine($"{item.Circuito}: {item.Qtd} alertas");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
