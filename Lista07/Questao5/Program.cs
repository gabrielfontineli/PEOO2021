using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(FormatarTexto(s));
        }
        public static string FormatarTexto(string texto)
        {
            string s = texto;
            s = s.Trim();
            int p = s.IndexOf(" ");
            while(p!= -1)
            {
                s = s.Remove(p, 1);
                p = s.IndexOf(" ");
            }
            return s;
        }
    }
}
