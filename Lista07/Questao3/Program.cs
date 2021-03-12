using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args){
            double x = double.Parse(Console.ReadLine());
            int y,z;
            Intervalo(x, out y, out z);
            Console.WriteLine($"[{y}, {z}]");

        }
        public static void Intervalo(double x, out int inicio, out int fim){
            inicio = (int) x;
            fim = inicio+1;
        }   
    }
}
