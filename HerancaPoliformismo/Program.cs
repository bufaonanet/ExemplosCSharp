using System;
using System.Collections.Generic;
using System.Globalization;
using HerancaPoliformismo.Entities;
using HerancaPoliformismo.Enums;

namespace HerancaPoliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Shap>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Colors colors = Enum.Parse<Colors>(Console.ReadLine());

                if (op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new Rectangle(width, height, colors));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circle(radius, colors));
                }
            }

            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS:");

            foreach (var item in lista)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }

        static void ListaDeEmpregados()
        {
            List<Employee> employees = new List<Employee>();


            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"*** Employee #{i} data ***");
                Console.Write("Outsourced (y/n)?");
                string opcao = Console.ReadLine().ToUpper();

                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Hour:");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opcao == "Y")
                {
                    Console.Write("Additional charge:");
                    double addicionalCarge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hour, valuePerHour, addicionalCarge));
                }
                else
                {
                    employees.Add(new Employee(name, hour, valuePerHour));
                }
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("PAYMENTS:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        static void teste()
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1000, "Douglas", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1001, "Gildete", 500.00, 1000.00));
            accounts.Add(new SavingsAccount(1002, "Bufão", 500.00, 0.1));
            accounts.Add(new BusinessAccount(1003, "Dete", 500.00, 1000.00));

            double sum = 0.0;

            foreach (var conta in accounts)
            {
                sum += conta.Balance;
            }

            Console.WriteLine("Total balance : " + sum.ToString("F2"));

            foreach (var conta in accounts)
            {
                conta.WithDraw(10);
            }

            foreach (var conta in accounts)
            {
                Console.WriteLine("Update balance accout numer:" +
                    conta.Number +
                    " - balance " +
                    conta.Balance);
            }
        }
    }
}
