using System;

namespace URI2456
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] gplays = Console.ReadLine().Split();
            int n1,n2,n3,n4,n5;
            n1 = int.Parse(gplays[0]);n2 = int.Parse(gplays[1]);n3 = int.Parse(gplays[2]); n4 = int.Parse(gplays[3]);n5 = int.Parse(gplays[4]);
            int[] gg = {n1,n2,n3,n4,n5};
            int [] certo = gg;
            Array.Sort(gg);

            if (gg[0] == certo[0] && gg[1] == certo[1] && gg[2] == certo[2] && certo[3] == gg[3])
            Console.WriteLine("c"); 

                    
        }
    }
}
