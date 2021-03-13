using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            circulo x;
            x = new circulo();
            x.raio = 3;
            Console.WriteLine(x.CalcArea());
            Console.WriteLine(x.CalcCirc());
        }
    }
    class circulo
    {
        public double raio;
        public double CalcArea()
        {
            return Math.PI * Math.Pow(raio,2);
        }
        public double CalcCirc()
        {
            return Math.PI * 2 * raio;
        }
    }
}
