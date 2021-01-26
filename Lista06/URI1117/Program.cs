using System;

namespace URI1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int val = 0;

            while (val<2){
            double n = double.Parse(Console.ReadLine());
            if (n>=0.0 && n<=10.0){
                soma += n;
                val += 1;}
            else if ((n < 0) || (n > 10)) Console.WriteLine("nota invalida");
            }
            Console.WriteLine($"media = {soma/2:.00}");
        }
    }
}
