using System;

namespace URI1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gplays = Console.ReadLine().Split();

            int n1,n2,n3;
            n1 = int.Parse(gplays[0]); n2 = int.Parse(gplays[1]); n3 = int.Parse(gplays[2]);

            if (n1 <= n2 && n1 <= n3)
            {
                Console.WriteLine(n1);
                if (n2 < n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else 
                {
                Console.WriteLine(n3);
                Console.WriteLine(n2);
                }
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                Console.WriteLine(n2);
                if (n1<n3)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
                }
            else if (n3 <= n1 && n3 <= n2 )
            {
                Console.WriteLine(n3);
                if (n2<n1)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
                else
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
            }
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);



        }
    }
}
