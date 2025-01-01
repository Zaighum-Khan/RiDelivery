using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiDelivery
{
    public class UserOrderInterface
    {
        public static void OrderInterface()
        {
            
            string fName = "Providers/Restaurants";
            string[] files = Directory.GetFiles(fName);
            Console.WriteLine("Files in directory:");
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
        }
    }
}