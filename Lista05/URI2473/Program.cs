using System;

namespace URI2473
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] aposta = Console.ReadLine().Split();
            string [] resultado = Console.ReadLine().Split();
            int aux = 0;

            for(int i = 0; i<6; i++){
                if(aposta[0] == resultado[i])aux++;
                else if(aposta[1] == resultado[i])aux++;
                else if(aposta[2] == resultado[i])aux++;
                else if(aposta[3]== resultado[i])aux++;
                else if(aposta[4]== resultado[i])aux++;
                else if (aposta[5]== resultado[i])aux ++; 
                
            };
            string[] certo = {"azar","azar","azar", "terno","quadra","quina","sena"};
            Console.WriteLine(certo[aux]);
        }
    }
}
