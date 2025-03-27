using Herança_Poliformismo_exercício2.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Herança_Poliformismo_exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão cadastrados no sistema?");
            int n = int.Parse(Console.ReadLine());

            List<Produto> Lista = new List<Produto>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados do produto #{i + 1}: ");

                Console.Write("Comum, Usado ou Importado (c, u, i) ?");
                char categoria = char.Parse(Console.ReadLine());

                if (categoria == 'i')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Taxa de importação: ");
                    double taxa = double.Parse(Console.ReadLine());
                    Produto produto = new ProdutoImportado(taxa, nome, preco);
                    Lista.Add(produto);
                } 
                else if (categoria == 'c')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Produto produto = new Produto(nome, preco);
                    Lista.Add(produto);
                }
                else if(categoria == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Data de fabricação: ");
                    DateTime data1 = DateTime.Parse(Console.ReadLine());
                    String data = data1.ToString("dd/MM/yyy");
                    Produto produto = new ProdutoUsado(data, nome, preco);
                    Lista.Add(produto);
                }
            }

            Console.WriteLine("TAG'S DE PREÇO: ");
            foreach(Produto obj in Lista)
            {
                Console.WriteLine(obj.TagPreço(obj));
            }
        }
    }
}
