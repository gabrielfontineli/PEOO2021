using System;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, p1, p2, res;
            string[] entrada = Console.ReadLine().Split(' ');
            string [] entrada1 = Console.ReadLine().Split(' ');

            x1 = double.Parse(entrada[0]); y1 = double.Parse(entrada[1]);
            x2 = double.Parse(entrada1[0]); y2 = double.Parse(entrada1[1]);
            p1 = x2 - x1; p2 = y2 - y1;
        
            res = Math.Sqrt((p1*p1) + (p2*p2));

            Console.WriteLine($"{res:.0000}");
        }
    }
}
