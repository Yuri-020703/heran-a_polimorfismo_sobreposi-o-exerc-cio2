using System;
using System.Collections.Generic;
using System.Globalization;

namespace Herança_Poliformismo_exercício2.Entites
{
    internal class ProdutoUsado : Produto
    {
        public string DataFabricacao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string dataFabricacao, string nome, double preço) : base(nome, preço)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string TagPreço(Produto produto)
        {
            return $"{produto.Nome} (usado) $ {produto.Preço} (Data de fabricação: {DataFabricacao}).";
        }
    }
}
