using System;

namespace FolhaDePagamento.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int hour { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            this.hour = hour;
        }

        public double TotalValue()
        {
            return hour * ValuePerHour;
        }
    }
}
