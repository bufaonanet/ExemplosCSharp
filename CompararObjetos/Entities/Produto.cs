using System;
using System.Globalization;

namespace Entities
{
    class Produto 
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString()
        {
            return nome + ", " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }        
    }
}
