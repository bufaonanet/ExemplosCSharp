using System;
using System.Globalization;

namespace ControleEstoque.Classes
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProduto(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return "Dados do produto : "
                + Nome
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades,"
                + " Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }

    }
}
