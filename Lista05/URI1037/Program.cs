using System;

namespace URI1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double gplays = Convert.ToDouble(Console.ReadLine());

            if (gplays >= 0.0000 && gplays <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (gplays > 25.000000 && gplays <= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (gplays > 50.0000000 && gplays <= 75.0000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (gplays > 75.0000000 && gplays <= 100.0000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else Console.WriteLine("Fora de intervalo");
        }
    }
}
