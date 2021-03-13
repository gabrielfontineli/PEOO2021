using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina x;
            x = new Disciplina();
            x.nota1 = 50;
            x.nota2 = 55;
            x.nota3 = 56;
            x.nota4 = 58;
            x.notafinal= 80;
            Console.WriteLine(x.MediaParcial());
        }
    }

    class Disciplina
    {
        public int nota1,nota2,nota3,nota4,notafinal;
        public int media = ((nota1*2)+ (nota2*2)+ (nota3 * 3)+ (nota4*3))/10;
       

        public string MediaParcial()
        {
             public string parcial{
        if (media >= 60) 
            {
            parcial = $"Parabéns, você foi aprovado com a média de {media}";
            }
        else if (media < 60)
            {
            parcial = $"Que pena, você ficou na prova final com a média {media}, precisando de {120 - media}";
            }
            return parcial;
             }
        }
        /*public int MediaFinal()
        {
        }*/
    }
    
}

