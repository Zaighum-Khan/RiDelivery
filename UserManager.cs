
namespace RiDelivery
{
    public class UserManager
    { 
        public static void CustomerLogin()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("\nPlease Enter User Name : ");
                string fName = Console.ReadLine() + ".txt";
                string filepath = $"{fName}";
                if (File.Exists(filepath))
                {
                    LoginCheckers.passLoginChecker(filepath);
                    break;
                }
                else
                {
                    Console.WriteLine("UserName not Found !!\nPlease Try Again");
                }
            }
        }

        public static void CustomerRegistration()
        {
            Console.Clear();
            while (true)
            {
                string userName = RegistrationCheckers.userNameChecker();

                string phoneNumber = RegistrationCheckers.numberChecker();

                string fName = userName + ".txt";
                string filepath = $"{fName}";

                string email = RegistrationCheckers.emailChecker();

                string password = RegistrationCheckers.passwordChecker();

                if (!File.Exists(filepath))
                {
                    using (StreamWriter sw = new StreamWriter(filepath, true))
                    {
                        sw.WriteLine($"{email},{password}");
                    }
                    Console.WriteLine("\nYou are Registered Successfully !!");
                    break;
                }
                else
                {
                    Console.WriteLine("User Name already Taken!\nEnter any other User Name.");
                }
            }
        }


        // private List<User> users = new List<User>();

        // public void RegisterUser()
        // {
        //     var user = new User();
            
        //     Console.WriteLine("Enter Full Name: ");
        //     user.Name = Console.ReadLine();

        //     Console.WriteLine("Enter Email: ");
        //     user.Email = Console.ReadLine();

        //     Console.WriteLine("Enter Password: ");
        //     user.Password = Console.ReadLine();

        //     Console.WriteLine("Enter Contact (Phone Number): ");
        //     user.Contact = Console.ReadLine();

        //     Console.WriteLine("Enter Address: ");
        //     user.Address = Console.ReadLine();

        //     users.Add(user);

        //     Console.WriteLine("Registration Successful!\n");
        //     user.PrintUserDetails();
        // }

        

        // public void LoginUser()
        // {
        //     Console.WriteLine("Enter Email: ");
        //     string email = Console.ReadLine();

        //     Console.WriteLine("Enter Password: ");
        //     string password = Console.ReadLine();

        //     var user = users.Find(u => u.Email == email && u.Password == password);

        //     if (user != null)
        //     {
        //         Console.WriteLine("Login Successful!");
        //         user.PrintUserDetails();
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid Email or Password. Please try again.");
        //     }
        // }
    }
}