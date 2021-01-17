using System;

namespace URI2456
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] gplays = Console.ReadLine().Split();
            int[] gg = new int[5];
            for (int i = 0; i < 5; i++){
                gg[i]= int.Parse(gplays[i]);
            }
            int a = 0; int b = 0; bool C = true; bool D = true;
            for (int i = 0; i <4; i++){
                a = gg[i];
                b = gg[i+1];
                    if (C && b < a) C = false;
                    if(D && b > a) D = false;
                    if (!(D) && !(C)) break;
            }
            if(C) Console.WriteLine("C");
            else if(D)
            Console.WriteLine("D");
            else Console.WriteLine("N");

                    
        }
    }
}
