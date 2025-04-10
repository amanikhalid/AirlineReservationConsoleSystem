using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace AirlineReservationConsoleSystem
{
    internal class Program
    {
        static int choice; 
        static void Main(string[] args)
        {
            DisplayWelcomeMessage();

            ///////////////
        }

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Airline Reservation Console System \n");
        }

        public static void ShowMainMenu(int choice)
        {
            while (true)
            {

                try //handle the exception if the user enter invalid input
                {
                    //Menu System
                    Console.Clear();
                    Console.WriteLine("Welcome to program menu \n");
                    Console.WriteLine("Select a Program:");
                    Console.WriteLine("1. Add Flight");
                    Console.WriteLine("2. Display All Flights ");
                    Console.WriteLine("3. Find Flight By Code");
                    Console.WriteLine("4. Update Flight Departure");
                    Console.WriteLine("5. Cancel Flight Booking");
                    Console.WriteLine("6. Book Fligh");
                    Console.WriteLine("7. Validate Flight Code");
                    Console.WriteLine("8. Generate Booking ID");
                    Console.WriteLine("9. Display Flight Details");
                    Console.WriteLine("10. Search Bookings By Destination");
                    Console.WriteLine("11. Calculate Fare");

                    Console.Write("Enter your choice : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: AddFLight(); break;
                        case 2: DisplayAllFlights(); break;
                        case 3: FindFlightByCode(); break;
                        case 4: UpdateFlightDeparture(); break;
                        case 5: CancelFlightBooking(); break;
                        case 6: BookFligh(); break;
                        case 7: ValidateFlightCode(); break;
                        case 8: GenerateBookingID(); break;
                        case 9: DisplayFlightDetails(); break;
                        case 10: SearchBookingsByDestination(); break;
                        case 11: CalculateFare(); break;

                        case 12: return;

                        default: Console.WriteLine("Invalid Choice! Try again."); break;
                    }
                    Console.WriteLine("Press any key  "); //ask user to press any key to continue
                    Console.ReadLine(); //read the user input

                }
                catch (Exception e)//show exception message if the user enter invalid input
                {
                    Console.WriteLine(e.Message);


                    Console.WriteLine("Invalid Choice! Try again.");
                    Console.WriteLine("Press any key  "); //ask user to press any key to continue
                    Console.ReadLine(); //read the user inputConsole.ReadLine();
                }

            }
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
