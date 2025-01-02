using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiDelivery
{
    public class EnlisterInterface
    {
        public static void ROwnerInterface(string restaurantName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to RiDelivery!");
            Console.WriteLine("1. Check Restaurant's Orders History \n2. Exit \n3. Go Back \n4. Change Password");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine() ?? "0");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ride History : ");
                    ROrderHistory(restaurantName);
                    break;
                case 2:
                    Console.WriteLine("Exiting the program...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case 3:
                    Menu.DisplayMenu();
                    break;
                case 4:
                    passChanger.changePass($"Providers/ROwners/{restaurantName}.txt");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static void ROrderHistory(string restaurantName)
        {
            Console.Clear();
            string fileName = $"Providers/ROwners/Orders/{restaurantName}_RideHistory.txt";
            if(File.Exists(fileName))
            {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string parts = sr.ReadToEnd();
                Console.WriteLine(parts);
            }

            Console.WriteLine("Press any key to go back...");
            if(Console.ReadKey() != null)
            {
                ROwnerInterface(restaurantName);
            }
            }
            else
            {
                Console.WriteLine("No Orders Yet!");
                Thread.Sleep(1500);
                ROwnerInterface(restaurantName);
            }
        }

        public static void SOwnerInterface(string shopName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to RiDelivery!");
            Console.WriteLine("1. Check Store's Orders History \n2. Exit \n3. Go Back \n4. Change Password");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine() ?? "0");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ride History : ");
                    SOrderHistory(shopName);
                    break;
                case 2:
                    Console.WriteLine("Exiting the program...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case 3:
                    Menu.DisplayMenu();
                    break;
                case 4:
                    passChanger.changePass($"Providers/SOwners/{shopName}.txt");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static void SOrderHistory(string shopName)
        {
            Console.Clear();
            string fileName = $"Providers/SOwners/Orders/{shopName}_OrderHistory.txt";
            if(File.Exists(fileName))
            {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string parts = sr.ReadToEnd();
                Console.WriteLine(parts);
            }

            Console.WriteLine("Press any key to go back...");
            if(Console.ReadKey() != null)
            {
                SOwnerInterface(shopName);
            }
            }
            else
            {
                Console.WriteLine("No Orders Yet!");
                Thread.Sleep(1500);
                SOwnerInterface(shopName);
            }
        }

        
    }
}