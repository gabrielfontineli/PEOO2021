using System;

namespace Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("E agora insira sua matricula");
            string matricula = Console.ReadLine();

            Console.WriteLine($"Nome:{nome}\nMatricula:{matricula}");
        }
    }
}
