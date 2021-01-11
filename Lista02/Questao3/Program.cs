using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
            int primeira = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
            int segunda = int.Parse(Console.ReadLine());
            Console.WriteLine($"Media parcial = {(primeira*2+segunda*3)/5}");

        }
    }
}
