namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            #region Q1
            #region a
            // 1- Owner and Balance are declared as public, so any other class can change them directly
            // 2- no validation on Balance -> any code can set Balance to a negative value without using Withdraw()
            // 3- Withdraw() has no validation -> The method subtracts the amount without checking if there is enough balance
            #endregion
            #region b

            //- make the fields private instead of public
            //- use properties (get/set) to control access
            //- add validation inside Withdraw()
            //- prevent direct modification of Balance from outside the class

            #endregion
            #region c
            /*
            - it breaks encapsulation
            - it allows invalid data ,like negative balance
            - you lose control over how data is modified
            - if you change the internal design later, other classes may break
             */
            #endregion
            #endregion
            #region Q2
            /*
            1- field :
            - variable declared inside a class
            - stores data directly
            - usually private
            - doesn't contain logic
             */

            /*
             2- property:
           - provides controlled access to a field
           - uses get and set
           - can contain logic -> validation, calculations
           - supports encapsulation
             */

            /*
            3- can a property contain logic?
            - yes, a property can contain validation or calculations inside get or set
             */

            // 4- example:
            //    private double salary;
            //    private double bonus;
            //public double TotalIncome
            //{
            //    get
            //    {
            //        return salary + bonus;
            //    }
            //}

            #endregion
            #region Q3
            #region a
            // it's called an indexer , it allows an object to be accessed like an array
            #endregion
            #region b
            // if register[10] is used while the array size is 5, it will cause IndexOutOfRangeException at runtime

            // to make it safer, add validation inside get and set:

            //     public string this[int index]
            //     {
            //    get
            //    {
            //        if (index >= 0 && index < names.Length)
            //            return names[index];

            //        return "invalid indix";
            //    }
            //    set
            //    {
            //        if (index >= 0 && index < names.Length)
            //            names[index] = value;
            //    }
            //}
            #endregion
            #region c
            // yes, a class can have more than one indexer
            // it be useful if they have different parameter types

            #endregion
            #endregion
            #region Q4
            // a)
            // static means the variable belongs to the class itself,not to individual objects
            // there is only one copy shared between all objects

            // TotalOrders is shared
            // Item is instance-level, each object has its own copy


            // b)
            // no, a static method cannot access Item directly, because Item is an instance field
            // static methods can only access static members

            #endregion
            #endregion
            #region part02
            Console.WriteLine("======== Ticket Booking ========\n");
            Cinema cinema = new Cinema();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nEnter data for Ticket {i}:");

                Console.Write("Movie Name: ");
                string movie = Console.ReadLine();

                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                TicketType type = (TicketType)int.Parse(Console.ReadLine());

                Console.Write("Seat Row (A-Z): ");
                char row = char.Parse(Console.ReadLine());

                Console.Write("Seat Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Ticket ticket = new Ticket(movie, type, new SeatLocation(row, number), price);

                cinema.AddTicket(ticket);
            }

            Console.WriteLine("\n========== All Tickets ==========");

            for (int i = 0; i < 3; i++)
            {
                if (cinema[i] != null)
                    Console.WriteLine(cinema[i]);
            }

            Console.WriteLine("\n========== Search by Movie ==========");
            Console.Write("Enter movie name to search: ");
            string searchName = Console.ReadLine();

            var found = cinema.GetMovie(searchName);

            if (found != null)
                Console.WriteLine($"Found: {found}");
            else
                Console.WriteLine("Movie not found.");

            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            Console.WriteLine($"\nBooking Reference 1: {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

            double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount (5 tickets x 80 EGP): {groupTotal} EGP (10% off applied)");
        }
    }

    #endregion

}
    

