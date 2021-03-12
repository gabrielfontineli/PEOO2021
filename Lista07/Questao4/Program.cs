using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"O MMC entre {x} e {y} eh {MMC(x,y)}");
        }
        public static int MMC (int x, int y)
        {
            int maior = x;
            int menor = y;
            if(y > maior ) 
            {
                maior = y;
                menor = x;
            }
            for (int i = 1; i<=menor;i++)
            {
                if ((maior*i)%menor == 0)
                {
                    return i*maior;
                }
            }
            return menor;
        }
    }
}
