using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBreaker.Services
{
    public static class LoginService
    {
        public static bool RealizarLogin()
        {
            Console.WriteLine("=== Login ===");
            Console.Write("Usuário: ");
            string? usuario = Console.ReadLine();
            Console.Write("Senha: ");
            string? senha = LerSenha();

            if (usuario == "admin" && senha == "1234")
            {
                Console.WriteLine("Login realizado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Credenciais inválidas.");
                return false;
            }
        }

        private static string LerSenha()
        {
            string senha = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    senha += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && senha.Length > 0)
                {
                    senha = senha[..^1];
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return senha;
        }
    }
}
