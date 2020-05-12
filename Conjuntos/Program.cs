using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(1);
            A.Add(3);
            A.Add(5);
            A.Add(7);

            B.Add(2);
            B.Add(4);
            B.Add(6);
            B.Add(7);
            B.Add(1);

            Console.WriteLine("Conjunto A");
            foreach (var x in A)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------------------");

            Console.WriteLine("Conjunto B");
            foreach (var x in B)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------------------");

            A.ExceptWith(B);

            Console.WriteLine("Conjunto A");
            foreach (var x in A)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------------------");



        }
    }
}
