using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base e a altura do triangulo");
            double b = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {b*a:.00} - Perimetro = {b*2+a*2:.00} - Diagonal = {Math.Sqrt (Math.Pow(b,2)+Math.Pow(a,2)):.00}");

        }
    }
}
