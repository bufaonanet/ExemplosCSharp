using ControleEstoque.Classes;
using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static void TestaControle()
        {
            Console.WriteLine("Entre com os dados do produto.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine(p);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Digite a quantidade a ser adicionada");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine(p);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Digite a quantidade a ser removida");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine(p);
        }

        static void MediaAlturas()
        {
            Console.WriteLine("Entre com a quantidade de pessoas");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Entre com a º{i + 1} altura");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double somaAlturas = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                somaAlturas += vet[i];
            }

            double mediaAlturas = somaAlturas / n;

            Console.WriteLine("Média das alturas é = " + mediaAlturas.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
