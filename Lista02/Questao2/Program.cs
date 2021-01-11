using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo:");
            string[] nome = Console.ReadLine().Split();
            Console.WriteLine($"Bem vindo ao C#, {nome[0]}");
        }
    }
}
