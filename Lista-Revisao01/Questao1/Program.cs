using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            esfera x = new esfera();
            x.SetRaio(5);
            double volume = x.CalcVolume();
            double area = x.CalcArea();
            Console.WriteLine(volume);
            Console.WriteLine(area);
        }
    }
    class esfera 
    {
        private double raio;
        
        public void SetRaio(double r) {
        if(r>0)raio = r;}

        public double GetRaio(){
        return raio;}

        public double CalcArea(){
        return 4*3.14*Math.Pow(raio,2);}

        public double CalcVolume(){
        return (3.14*4*Math.Pow(raio,3))/3;}
    }
}
