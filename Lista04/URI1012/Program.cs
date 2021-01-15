using System;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] entrada = Console.ReadLine().Split();
            double a,b,c;
            a = double.Parse(entrada[0]); b = double.Parse(entrada[1]);c = double.Parse(entrada[2]);

            Console.WriteLine($"TRIANGULO: {a*c/2:0.000}\nCIRCULO: {Math.Pow(c,2)*3.14159:0.000}\nTRAPEZIO: {c*(a+b)/2:0.000}\nQUADRADO: {Math.Pow(b,2):0.000}\nRETANGULO: {a*b:0.000}");
        }
    }
}
