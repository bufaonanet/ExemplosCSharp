using System;
using System.Globalization;

namespace MediaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Media()
        {
            int n = int.Parse(Console.ReadLine());

            Product[] p = new Product[n];

            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"Entre como  nome do º{i + 1} produto");
                string nome = Console.ReadLine();

                Console.WriteLine($"Entre com seu preço");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                p[i] = new Product { Name = nome, Price = preco };
            }


            double soma = 0.0;

            for (int i = 0; i < p.Length; i++)
            {
                soma += p[i].Price;
            }

            double avg = soma / n;

            Console.WriteLine("A média é = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
