using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do estado:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o número de habitantes:");
            int habitantes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a área do estado em Km²:");
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"A densidade demógrafica do {nome} é de {habitantes/area:.0} hab/km²");
        }
    }
}
