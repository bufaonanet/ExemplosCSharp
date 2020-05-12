using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1986, 9, 21, 7, 45, 30);
            DateTime d2 = d1.AddHours(1);

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            
            




        }

        static void UsandoSwitch()
        {
            Console.Write("Digite o número correspondente ao dia da semana: ");
            int numero = int.Parse(Console.ReadLine());

            string dia;

            switch (numero)
            {
                case 1:
                    dia = "Sunday";
                    break;
                case 2:
                    dia = "Monday";
                    break;
                case 3:
                    dia = "Tusday";
                    break;
                case 4:
                    dia = "Wensday";
                    break;
                case 5:
                    dia = "Thursday";
                    break;
                case 6:
                    dia = "Friday";
                    break;
                case 7:
                    dia = "Friday";
                    break;
                default:
                    dia = "Dia inválido";
                    break;
            }

            Console.WriteLine("Dia da semana é : " + dia);
        }
        static void OperadorTernario()
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            preco -= desconto;

            Console.WriteLine("Preço final é :" + preco);
        }
        static void ManipulandoString()
        {
            string original = "abce FGHIJ ABC abc DFGH   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("FG");
            int n2 = original.LastIndexOf("FG");

            string s4 = original.Substring(5);
            string s5 = original.Substring(5, 4);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("ABC", "123");

            Console.WriteLine("Original -" + original + "-");
            Console.WriteLine("ToUpper -" + s1 + "-");
            Console.WriteLine("ToLower -" + s2 + "-");
            Console.WriteLine("Trim -" + s3 + "-");
            Console.WriteLine("IndexOf 'FG' :" + n1 + "-");
            Console.WriteLine("LastIndexOf 'FG' :" + n2 + "-");
            Console.WriteLine("Substring (5) :" + s4 + "-");
            Console.WriteLine("Substring (5,5) :" + s5 + "-");
            Console.WriteLine("Replace 'a' to 'x' :" + s6 + "-");
            Console.WriteLine("Replace 'ABC' to '123' :" + s7 + "-");
        }
    }
}
