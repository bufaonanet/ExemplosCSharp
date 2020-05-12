using System;
using Excecao.Entities.Exptions;

namespace Excecao.Entities
{
    class Reservation
    {
        public int RoomNamber { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation()
        {
        }
        public Reservation(int roomNamber, DateTime checkIn, DateTime chekOut)
        {
            if (checkIn < DateTime.Now)
            {
                throw new DomainExeption("Data de checkin não deve ser anterior a data atual");
            }

            if (chekOut <= checkIn)
            {
                throw new DomainExeption("Data de checkout deve ser posterior a data de checkin");
            }

            RoomNamber = roomNamber;
            CheckIn = checkIn;
            CheckOut = chekOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)

        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainExeption("As datas de reserva tem que ser datas futuras");
            }

            if (checkIn >= checkOut)
            {
                throw new DomainExeption("A data de checkout deve ser posterior a de checkin");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Reservation: Room "
                + RoomNamber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", duration: "
                + Duration()
                + " nights";
        }
    }
}
