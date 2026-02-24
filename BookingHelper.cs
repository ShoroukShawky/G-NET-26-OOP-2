using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class BookingHelper
    {
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if (numberOfTickets >= 5)
            {
                return pricePerTicket * numberOfTickets * 0.9;
            }
            return pricePerTicket * numberOfTickets;
        }

        private static int count = 0;
        public static string GenerateBookingReference()
        {
          
            return $"BK-{++count}";
        }
    }
}
