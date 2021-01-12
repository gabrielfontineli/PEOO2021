using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] ent = Console.ReadLine().Split();
            double a,b,c;
            a = double.Parse(ent[0]);b = double.Parse(ent[1]);c = double.Parse(ent[2]);
            double ab = (a + b +Math.Abs(a-b))/2;
            Console.WriteLine($"{(ab + c +Math.Abs(ab-c)) /2} eh o maior");
        }
    }
}
