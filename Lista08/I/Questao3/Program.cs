using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação no formato op1+op2:");
            string[] op = Console.ReadLine().Split('+');
            int soma = int.Parse(op[0])+ int.Parse(op[1]);
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
