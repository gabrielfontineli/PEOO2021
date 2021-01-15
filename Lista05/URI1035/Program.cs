using System;

namespace URI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gplays = Console.ReadLine().Split();
            int a,b,c,d;
            a = int.Parse(gplays[0]); b = int.Parse(gplays[1]); c = int.Parse(gplays[2]); d = int.Parse(gplays[3]);
            if (b>c && d > a && (c+d)> (a+b) && c > 0 && d > 0 && a%2 == 0) Console.WriteLine("Valores aceitos");
            else Console.WriteLine("Valores nao aceitos");
        }
    }
}
