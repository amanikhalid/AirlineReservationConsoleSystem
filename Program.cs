using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace AirlineReservationConsoleSystem
{
    internal class Program
    {
        static List<Flight> flights = new List<Flight>();
        static List<Booking> bookings = new List<Booking>();

        public static void Main(string[] args)
        {
            AddFlight("F11", "Nashville", "Denver", DateTime.Now.AddHours(4), 330);
            AddFlight("F22", "Muscat", "Suhar", DateTime.Now.AddHours(1), 60);
            StartSystem();
        }

        class Flight
        {
            public string FlightCode;
            public string FromCity;
            public string ToCity;
            public DateTime DepartureTime;
            public int Duration;
        }

        class Booking
        {
            public string PassengerName;
            public string FlightCode;
            public string BookingID;
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Airline Reservation System!");
            Console.WriteLine("   ");
        }

        static int ShowMainMenu()
        {
            Console.WriteLine("\n1. Book Flight");
            Console.WriteLine("2. Cancel Flight");
            Console.WriteLine("3. View All Flights");
            Console.WriteLine("4. View Flight Details");
            Console.WriteLine("5. Search Bookings by Destination");
            Console.WriteLine("6. Update Flight Departure Time");
            Console.WriteLine("7. Calculate Fare");
            Console.WriteLine("8. Exit");
            Console.Write("Enter choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
                return choice;
            return -1;
        }

        static void AddFlight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration)
        {
            flights.Add(new Flight
            {
                FlightCode = flightCode,
                FromCity = fromCity,
                ToCity = toCity,
                DepartureTime = departureTime,
                Duration = duration
            });
        }

        static void DisplayAllFlights()
        {
            Console.WriteLine("\nAvailable Flights:");
            foreach (var flight in flights)
            {
                Console.WriteLine($"{flight.FlightCode}: {flight.FromCity} -> {flight.ToCity}, Departs at {flight.DepartureTime}, Duration: {flight.Duration} min");
            }
        }

        public static void UpdateFlightDeparture()
        {

        }

        public static void CancelFlightBooking()
        {

        }

        public static void BookFligh()
        {

        }

        public static void ValidateFlightCode()
        {

        }

        public static void GenerateBookingID()
        {

        }

        public static void DisplayFlightDetails()
        {

        }

        public static void SearchBookingsByDestination()
        {

        }

        public static void CalculateFare()
        {

        }
    }
}
