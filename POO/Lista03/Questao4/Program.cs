using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Equacao x = new Equacao(10,20,30);
            double x1, x2;
            x1 = -Math.Sqrt(x.Delta())
            x.RaizesReais(out x1, out x2);
            Console.WriteLine("Hello World!");
        }
    }
    class Equacao
    {
        private double a,b,c;
        public Equacao(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SetABC(double a, double b, double c)
        {
            if (a==0)this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetABC(out double a, out double b, out double c)
        {
           a = this.a;
           b = this.b;
           c = this.c;
        }
        public bool RaizesReais(out double x1, out double x2)
        {
            if(Delta() >= 0) return 
            {
                x1 = (-b + Math.Sqrt(Delta()))/2*a;
                x2 = (-b - Math.Sqrt(Delta()))/2*a;
            }
        }
        public double Delta()
        {
            return Math.Pow(b,2) - (4 * a * c);
        }
    }
}
