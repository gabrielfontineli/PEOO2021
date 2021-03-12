using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"o maior eh: {maior(a,b)} ");
        }

        public static double maior(double a, double b){
            double maior;
            if (a > b) maior = a;
            else maior = b;
            return maior;
        }
    }
}
