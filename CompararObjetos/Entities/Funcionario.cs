using System;
using System.Globalization;

namespace Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string linha)
        {
            string[] vet = linha.Split(',');
            Nome = vet[0];
            Salario = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("O objeto comparado não é um funcionário:");
            }

            Funcionario outro = obj as Funcionario;

            return Nome.CompareTo(outro.Nome);            
        }

        
    }
}
