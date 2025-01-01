using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiDelivery
{
    public class UserRideInterface
    {
        public static void RideInterface()
        {
            Console.Write("Enter Your Pick-Up Location : ");
            string pickUp = Console.ReadLine() ?? "";
            Console.Write("Enter Your Drop-Off Location : ");
            string dropOff = Console.ReadLine() ?? "";

            //Riders info presented for selection
            Console.Write("Select a Rider : ");
            Console.Write("Enter Rider Name: ");
            string riderName = Console.ReadLine() ?? "";
            //Order Receipt and printation on both users and riders file
        }
    }
}