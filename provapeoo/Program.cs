using System;

namespace teste
{
    class Program
    {
        public static int testedemaior(string n){
            int maior = int.Parse(n[0].ToString());
            for(int i = 1; i < n.Length; i++){
                int teste = int.Parse(n[i].ToString());
                if(teste > maior) {
                    maior = teste; 
                    }
              
            }
            return maior;
        }
        static void Main(string[] args)
        {
            string n = "";
                while(n != "0"){
                        n = Console.ReadLine();
                        if (n == "0") break;
                        Console.WriteLine($"Maior algarismo = {testedemaior(n)}");
                }
        }
    }
}
