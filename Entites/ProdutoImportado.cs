using System;
using System.Collections.Generic;
using System.Globalization;

namespace Herança_Poliformismo_exercício2.Entites
{
    internal class ProdutoImportado : Produto
    {
        public double Taxa { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(double taxa, string nome, double preço) : base(nome, preço)
        {
            Taxa = taxa;
        }

        public override string TagPreço(Produto produto)
        {
            return $"{produto.Nome} $ {PreçoTotal(produto)} (Taxa de importação: $ {Taxa}).";
        }

        public double PreçoTotal(Produto produto)
        {
            return produto.Preço + Taxa;
        }
    }
}
