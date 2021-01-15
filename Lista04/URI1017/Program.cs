using System;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas = double.Parse(Console.ReadLine());
            double velocidade = double.Parse(Console.ReadLine());
            double combustivel = (velocidade*horas)/12;
            Console.WriteLine($"{combustivel:.000}");
        }
    }
}
