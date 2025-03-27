using System;
using System.Collections.Generic;
using System.Globalization;

namespace Herança_Poliformismo_exercício2.Entites
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }

        public virtual string TagPreço(Produto produto)
        {
            return $"{produto.Nome} $ {produto.Preço}.";
        }
    }
}
