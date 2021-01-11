using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
            string[] intervalo = Console.ReadLine().Split(':');
            double h, m, s;
            h = double.Parse(intervalo[0])*3600;m = double.Parse(intervalo[1])*60; s = double.Parse(intervalo[2]);

            Console.WriteLine($"A luz percorreu {(h+m+s)*300000} km nesse intervalo");

        }
    }
}
