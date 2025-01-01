
namespace RiDelivery
{
    public class RiderManager
    {

        
        public static void riderRegistration()
        {

            Console.Clear();
            while (true)
            {
                string vehicleType;

                Console.WriteLine("Personal Info :");
                string userName = RegistrationCheckers.userNameChecker();

                string fName = userName + ".txt";
                string filepath = $"{fName}";

                if (!File.Exists(filepath))
                {
                    string email = RegistrationCheckers.emailChecker();

                    string phoneNumber = RegistrationCheckers.numberChecker();

                    Console.Write("Please enter Your Address : ");
                    string address = Console.ReadLine();

                    Console.WriteLine("\nVehicle Info : ");
                    vehicleType = RegistrationCheckers.vehicleTypeChecker();

                    Console.Write("Please Enter Vehicle Number : ");
                    string vehicleNumber = Console.ReadLine();

                    Console.Write("\nCreate Password :");
                    string password = RegistrationCheckers.passwordChecker();

                    using (StreamWriter sw = new StreamWriter(filepath, true))
                    {
                        sw.WriteLine($"{email},{password},{phoneNumber},{address},{vehicleType},{vehicleNumber}");
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

        public static void riderLogin()
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

        // private List<Riders> riders = new List<Riders>(); 

        // public void Rider()
        // {

        //     var rider = new Riders();
        //     Console.WriteLine("Enter Name: ");
        //     rider.Name = Console.ReadLine();

        //     Console.WriteLine("Enter Vehicle Type (1 for Bike , 2 for Car): ");
        //     rider.Vehicle = Console.ReadLine();

        //     Console.WriteLine("Enter License Number: ");
        //     rider.License = Console.ReadLine();

        //     Console.WriteLine("Enter Vehicle Plate Number: ");
        //     rider.NumPlate = Console.ReadLine();

        //     Console.WriteLine("Enter Contact (Phone Number): ");
        //     rider.Contact = Console.ReadLine();

        //     Console.WriteLine("Enter Address: ");
        //     rider.Address = Console.ReadLine();
                
        //     riders.Add(rider);

        // }
    }
}