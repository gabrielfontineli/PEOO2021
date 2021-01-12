using System;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"{x/y:.000} km/l");
        }
    }
}
