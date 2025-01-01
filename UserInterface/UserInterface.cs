using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiDelivery
{
    public class UserInterface
    {
        public static void userInterface(string uName)
        {

        
        Console.Clear();
        Console.WriteLine("Welcome to RiDelivery!");
        Console.WriteLine("1. Ride \n2. Order \n3. Exit \n4. Go Back");
        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
            case "1":
                UserRideInterface.RideInterface(uName);
                break;
            case "2":
                UserOrderInterface.OrderInterface(uName);
                break;
            case "3": 
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            case "4":
                Menu.LoginMenu();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;

            }
        }

        
    }
}