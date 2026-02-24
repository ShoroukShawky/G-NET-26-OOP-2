using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Ticket
    {
        private static int ticketCounter = 0;
        public int ticketID { get; }
        private string _movieName;
        public TicketType Type { get; set; }
        public SeatLocation Seatkocation { get; set; }
        private double price;
        public string MovieName
        {
            get { return _movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _movieName = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if(value > 0)
                price = value;
            }
        }
        public double PriceAfterTax
        {
            get
            { 
              return price + (price * 0.14);
            }
        }

       public Ticket(string movieName , TicketType type ,SeatLocation seat, double price )
        {
            ticketCounter++;
            ticketID = ticketCounter;
            _movieName = movieName;
            Type = type;
            Seatkocation = seat;
            Price = price;
        }

        public static int GetTotalTicketsSold()
        { return ticketCounter; }

        public override string ToString()
        {
            return $"Ticket #{ticketID} | {MovieName} | {Type} | Seat: {Seatkocation} | Price: {Price} EGP | After Tax: {PriceAfterTax:F1} EGP";
        }

    }
}
