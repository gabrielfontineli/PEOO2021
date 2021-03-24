using System;

namespace Revisao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Livro : IComparable
    {
        private string titulo, genero;
        private double preco;
        private int vendidos;
        public string Titulo {get;}
        public int Vendidos{get;}
        public Livro(string t, string g, double p)
        {
            titulo = t;
            genero = g;
            if (p>=0) preco = p;
        }
        public int CompareTo(object obj)
        {
            return Vendidos.CompareTo(((Livro)obj).Vendidos);
        }
        public string GetGenero()
        {
            return genero;
        }
        public void Vender()
        {
            Vendidos++;
        }
        public override string ToString()
        {
            return $"";
        }

    }
    class Livraria
    {
        private string nome;
        private int Qtd{get;}
        private Livro[] livros;
        public string Livro(string n)
        {
            
        }
        public void Inserir(Livro i)
        {
            livros += i;
        }
        public void Remover(Livro i)
        {}
        public Livro[] Listar()
        {
            Array.Sort(livros);
        }
        public Livro[] ListarGenero(string g)
        {}
        public Livro[] Top10Vendidos()
        {}
    }
}
