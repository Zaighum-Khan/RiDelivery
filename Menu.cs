namespace RiDelivery
{
    public static class Menu
    {

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.Write("1. Register \n2. Login \n3. Exit");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RegisterMenu();
                    break;
                case "2":
                    LoginMenu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    DisplayMenu();
                    break;
            }
        }

        public static void RegisterMenu()
        {
            Console.Clear();
            Console.Write("1. Register as a User \n2. Register as a Rider\n3. Register as a Provider \n4. Exit \n5. Go Back");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    UserManager.CustomerRegistration();
                    break;
                case "2":
                    RiderManager.riderRegistration();
                    break;
                case "3":
                    //ProviderManager.ProviderManager();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                case "5":
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        public static void LoginMenu()
        {
            Console.Clear();
            Console.Write("1. Login as a User \n2. Login as a Rider \n3. Login as a Provider \n4. Exit \n5. Go Back");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    UserManager.CustomerLogin();
                    break;
                case "2":
                    RiderManager.riderLogin();
                    break;
                case "3":
                    //ProviderManager.providerLogin();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                case "5":
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        // private UserManager userManager = new UserManager();
        // private ProviderManager ProviderManager = new ProviderManager();
        // private RiderManager RiderManager = new RiderManager();

        // public void DisplayMenu()
        // {
        //     while (true)
        //     {
        //         Console.WriteLine("\n1. User Registration");
        //         Console.WriteLine("2. User Login");
        //         Console.WriteLine("3. Provider Enlistment");
        //         Console.WriteLine("4. Rider Enlistment");
        //         Console.WriteLine("5. Exit");
        //         Console.Write("Enter your choice: ");

        //         string input = Console.ReadLine();
        //         if (int.TryParse(input, out int choice))
        //         {
        //             switch (choice)
        //             {
        //                 case 1:
        //                     userManager.RegisterUser();
        //                     break;
        //                 case 2:
        //                     userManager.LoginUser();
        //                     break;
        //                 case 3:
        //                     ProviderManager.Enlister();
        //                     break;
        //                 case 4:
        //                     RiderManager.Rider();
        //                     break;
        //                 case 5:
        //                     Console.WriteLine("Exiting the program. Goodbye!");
        //                     return;
        //                 default:
        //                     Console.WriteLine("Invalid choice. Please try again.");
        //                     break;
        //             }
        //         }
        //         else
        //         {
        //             Console.WriteLine("Invalid input. Please enter a number.");
        //         }
        //     }
        // }
    }
}