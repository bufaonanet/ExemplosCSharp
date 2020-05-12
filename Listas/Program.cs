using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string> {
                "Douglas",
                "Débora",
                "Bob"
            };

            lista.Add("Gildete");
            lista.Add("Ana");

            lista.Insert(0, "Domingos");

            foreach (var nome in lista)
            {
                Console.WriteLine(nome);
            }

            string s1 = lista.Find(nome => nome[0] == 'D');
            int pos1 = lista.FindIndex(nome => nome[0] == 'D');

            string s2 = lista.FindLast(nome => nome[0] == 'D');
            int pos2 = lista.FindLastIndex(nome => nome[0] == 'D');

            Console.WriteLine($"First 'D': {s1} - Pos º{pos1}");
            Console.WriteLine($"First 'D': {s2} - Pos º{pos2}");

            Console.WriteLine("--------------");
            List<string> listaFiltrada = lista.FindAll(nomes => nomes.Length == 3);

            foreach (var nome in listaFiltrada)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------");
            lista.RemoveRange(2, 3);
            Console.WriteLine("Nova Lista:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");
            lista.RemoveAll(nome => nome.Length == 3);
            Console.WriteLine("Nova Lista:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }









        }
    }
}
