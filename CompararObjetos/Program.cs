using System;
using System.IO;
using System.Collections.Generic;
using Entities;
namespace CompararObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaProdutos = new List<Produto>()
            {
                new Produto("NoteBook",1200.00),
                new Produto("Tablet",450.00),
                new Produto("TV",1800.00)
            };

            listaProdutos.Add(new Produto("Guitarra", 2500.00));
            listaProdutos.Sort(
                //(p1, p2) => p1.nome.ToUpper().CompareTo(p2.nome.ToUpper())
                (p1, p2) => p1.preco.CompareTo(p2.preco)
            ); ;


            foreach (var p in listaProdutos)
            {
                Console.WriteLine(p);
            }
        }

        static void teste()
        {
            string caminho = @"D:\ws-vs2019\lista.txt";

            var lista = new List<Funcionario>();

            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        lista.Add(new Funcionario(sr.ReadLine()));
                    }

                    lista.Sort();

                    foreach (var item in lista)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
