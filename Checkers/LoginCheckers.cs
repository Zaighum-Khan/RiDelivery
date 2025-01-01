using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiDelivery
{
    public class LoginCheckers
    {
        public static void passLoginChecker(string fName)
        {
            Console.Write("Please Enter Your Password : ");
                    string password = Console.ReadLine() ?? "";

                    string line;
                    using (StreamReader sr = new StreamReader(fName))
                    {
                        while ((line = sr.ReadLine() ?? "") != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts[1] == password)
                            {
                                Console.WriteLine("Logged In Successfully !!");
                                Thread.Sleep(1500);
                                break;
                            }
                            else{
                                Console.WriteLine("Password Incorrect !!\nPlease Try Again");
                                passLoginChecker(fName);
                            }
                        }
        }
    }
    }
}   