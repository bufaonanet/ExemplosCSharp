using System;
using System.Linq;
using services;
using Entities;
using System.Collections.Generic;

namespace ProgramacaoFuncional
{
    delegate void BinaryNumericOperation(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            //fonte de dados
            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            //definindo a expressão query
            var resultado = numeros
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //executando a query
            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

        }

        static void testes()
        {
            var list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            //list.RemoveAll(p => p.Price > 100); 
            //list.RemoveAll(removeProduto);  
            //list.ForEach(AumentandoValor);
            //var listaMaiuscula = list.Select(NameUpper).ToList();

            var listaMaiuscula = list.Select(p => p.Name.ToUpper());

            foreach (var item in listaMaiuscula)
            {
                Console.WriteLine(item);
            }
        }

        static bool RemoveProduto(Product p)
        {
            return p.Price < 100;
        }

        static void AumentandoValor(Product p)
        {
            p.Price *= 1.1;
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        static void TesteDelegate()
        {
            int a = 10;
            int b = 12;

            BinaryNumericOperation op = CalculationServices.ShowSum;
            op += CalculationServices.ShowMax;

            op(a, b);
        }

    }
}
