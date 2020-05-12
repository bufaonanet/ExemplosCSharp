using EnumeracaoEComposiccao.Entities;
using EnumeracaoEComposiccao.Entities.Enums;
using System;

namespace EnumeracaoEComposiccao
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Delivered.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");

            Console.WriteLine(os);
        }
    }
}
