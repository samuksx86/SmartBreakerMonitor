using SmartBreaker.Models;
using SmartBreaker.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBreaker.Services
{
    public class RegistroService
    {
        private readonly List<Evento> _eventos = new();

        public void RegistrarFalhaUsuario()
        {
            try
            {
                Console.Write("Circuito: ");
                string circuito = Console.ReadLine() ?? "Desconhecido";
                Console.Write("Tipo de Falha (Curto, Sobrecarga...): ");
                string tipo = Console.ReadLine() ?? "N/A";
                Console.Write("Mensagem: ");
                string msg = Console.ReadLine() ?? "Falha registrada";

                var falha = new Falha
                {
                    Circuito = circuito,
                    Tipo = tipo,
                    Mensagem = msg
                };

                _eventos.Add(falha);
                Logger.Log($"[FALHA] {msg} no circuito {circuito}.");
            }
            catch (Exception ex)
            {
                Logger.Log("Erro ao registrar falha: " + ex.Message);
            }
        }

        public void RegistrarAlertaUsuario()
        {
            try
            {
                Console.Write("Circuito: ");
                string circuito = Console.ReadLine() ?? "Desconhecido";
                Console.Write("Nível do Alerta (Crítico, Médio, Baixo): ");
                string nivel = Console.ReadLine() ?? "N/A";
                Console.Write("Mensagem: ");
                string msg = Console.ReadLine() ?? "Alerta emitido";

                var alerta = new Alerta
                {
                    Circuito = circuito,
                    Nivel = nivel,
                    Mensagem = msg
                };

                _eventos.Add(alerta);
                Logger.Log($"[ALERTA] {msg} no circuito {circuito}.");
            }
            catch (Exception ex)
            {
                Logger.Log("Erro ao registrar alerta: " + ex.Message);
            }
        }

        public List<Evento> ObterEventos() => _eventos;

        public void ExibirEventos()
        {
            Console.WriteLine("=== Eventos Registrados ===");
            foreach (var e in _eventos)
            {
                Console.WriteLine($"[{e.Timestamp}] {e.Circuito}: {e.Mensagem}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
