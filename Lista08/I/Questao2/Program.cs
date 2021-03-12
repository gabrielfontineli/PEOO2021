using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor gasto do combustível em reais:");
            double gasto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do litro do combustível em reais:");
            double porlitro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a distância percorrida em quilômetros:");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine($"O consumo médio é de {(distancia/(gasto/porlitro)):.00} Km por litro");
            Console.WriteLine($"O gasto por Km percorrido é {gasto/distancia:0.00}");

        }
    }
}
