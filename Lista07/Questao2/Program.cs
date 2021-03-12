using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Ordenar(ref a, ref b, ref c);
            Console.WriteLine($"\n{a} \n{b} \n{c}");
        }
        public static void Ordenar(ref int x, ref int y, ref int z){
            int maior = x;
            int menor = x;
            if (y > maior) maior = y;
            if(z > maior) maior = z;

            if(y < menor) menor = y;
            if(z< menor) menor = z;

            int meio = (x+y+z) - (maior+menor);

            z = maior;
            y = meio;
            x = menor;
        }
    }
}
