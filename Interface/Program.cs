using System;
using System.Globalization;
using Entities;
using Services;
using Enums;
using Figuras;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape c1 = new Circle() { Colors = Colors.Black, Radius = 2.0 };
            IShape c2 = new Rectangle() { Width = 3.5, Height = 4.2, Colors = Colors.Black};

            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }

        public void Locacao()
        {
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string car = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour:");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour:");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(car));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxServices());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
