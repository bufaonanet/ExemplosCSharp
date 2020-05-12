using System;
using FolhaDePagamento.Entities;
using FolhaDePagamento.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Enter Worker Level(Junior/Mid_level/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double workerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(workerName, level, workerSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valeuPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valeuPerHour, duration);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name:" + worker.Name);
            Console.WriteLine("Departament:" + worker.Departament.Name);
            Console.WriteLine($"Incame for{monthAndYear}: " +
                worker.Incame(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
