using System;
using FolhaDePagamento.Entities.Enums;
using System.Collections.Generic;

namespace FolhaDePagamento.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Incame(int year, int month)
        {
            double salario = BaseSalary;

            foreach (var contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    salario += contract.TotalValue();
                }
            }

            return salario;
        }

    }
}
