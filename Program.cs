using SmartBreaker.Models;
using SmartBreaker.Services;
using SmartBreaker.Utils;

class Program
{
    static void Main()
    {
        if (!LoginService.RealizarLogin())
        {
            Console.WriteLine("Acesso negado. Encerrando...");
            return;
        }

        var registroService = new RegistroService();
        var simuladorService = new SimuladorService(registroService);
        var relatorioService = new RelatorioService(registroService);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== SmartBreaker Console ===");
            Console.WriteLine("1. Registrar Falha");
            Console.WriteLine("2. Gerar Alerta");
            Console.WriteLine("3. Simular Evento Aleatório");
            Console.WriteLine("4. Ver Relatório de Falhas");
            Console.WriteLine("5. Ver Relatório de Alertas");
            Console.WriteLine("7. Ver Logs de Evento");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    registroService.RegistrarFalhaUsuario();
                    break;
                case "2":
                    registroService.RegistrarAlertaUsuario();
                    break;
                case "3":
                    string tipoSimulado = simuladorService.SimularFalhaOuAlerta();
                    Console.WriteLine($"Simulação concluída: {tipoSimulado} gerado.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "4":
                    relatorioService.ExibirRelatorioFalhas();
                    break;
                case "5":
                    relatorioService.ExibirRelatorioAlertas();
                    break;
                case "7":
                    registroService.ExibirEventos();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}