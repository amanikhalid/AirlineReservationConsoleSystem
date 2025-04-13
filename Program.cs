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

        public static void AddFLight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration)
        {

        }

        public static void DisplayAllFlights()
        {

        }

        public static void FindFlightByCode()
        {

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
