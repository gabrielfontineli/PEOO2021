using System;

namespace URI1061
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] di = Console.ReadLine().Split();
            string[] hri =Console.ReadLine().Split(':');
            string[] df = Console.ReadLine().Split();
            string[] hrf=Console.ReadLine().Split(':');

            int seg = int.Parse(hrf[2]) - int.Parse(hri[2]);
            int minuto = int.Parse(hrf[1]) - int.Parse(hri[1]);
            int hora = int.Parse(hrf[0]) - int.Parse(hri[0]);
            int dia = int.Parse(df[1]) - int.Parse(di[1]);
            if (seg < 0) {seg += 60;minuto -=1;}
            if (minuto <0){minuto+=60;hora-=1;}
            if (hora <0){hora+=24;dia -=1;}
            if (dia <= 0) dia = 0;
            
            Console.WriteLine($"{dia} dia(s)");
            Console.WriteLine($"{hora} hora(s)");
            Console.WriteLine($"{minuto} minuto(s)");
            Console.WriteLine($"{seg} segundo(s)");




        }
    }
}
