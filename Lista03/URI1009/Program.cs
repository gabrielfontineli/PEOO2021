using System;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
        
            Console.WriteLine($"TOTAL = R$ {salario + (0.15 * vendas):.00}");
        }
    }
}
