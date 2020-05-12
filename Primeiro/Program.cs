using System;
using Triangulo;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "maria", "josé", "ana" };

            foreach (var nome in vet)
            {
                Console.WriteLine(nome);
            }

        }

        static void chamada()
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área do triangulo x = " + areaX.ToString("F4"));
            Console.WriteLine("Área do triangulo y = " + areaY.ToString("F4"));

            Console.WriteLine();
        }

    }
}
