using SmartBreaker.Models;
using SmartBreaker.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBreaker.Services
{
    public class SimuladorService
    {
        private readonly RegistroService _registroService;
        private readonly Random _rand = new();

        public SimuladorService(RegistroService registroService)
        {
            _registroService = registroService;
        }

        public string SimularFalhaOuAlerta()
        {
            var circuitos = new[] { "Cozinha", "Sala", "Quarto", "Garagem" };
            string circuito = circuitos[_rand.Next(circuitos.Length)];

            if (_rand.Next(2) == 0)
            {
                var falha = new Falha
                {
                    Circuito = circuito,
                    Tipo = "Sobrecarga",
                    Mensagem = "Simulação de falha elétrica"
                };
                _registroService.ObterEventos().Add(falha);
                Logger.Log($"[FALHA SIMULADA] {falha.Mensagem} no {circuito}");
                return "FALHA";
            }
            else
            {
                var alerta = new Alerta
                {
                    Circuito = circuito,
                    Nivel = "Crítico",
                    Mensagem = "Simulação de alerta"
                };
                _registroService.ObterEventos().Add(alerta);
                Logger.Log($"[ALERTA SIMULADO] {alerta.Mensagem} no {circuito}");
                return "ALERTA";
            }
        }
    }
}
