using System.IO;
namespace RiDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu.DisplayMenu();
            customerReciept("Providers/Restaurants/Shahi");
        }
        
        public static void customerReciept(string restaurant)
{
    string fname = restaurant + ".txt";
    string ans;
    int totalBill = 0;

    Console.WriteLine("\nWhat do you want to buy:");
    string[] lines = File.ReadAllLines(fname);

    do
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();
        bool itemFound = false;

        // Search for the item in the file
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts[0].Trim().Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                itemFound = true;

                int quantity;
                while (true)
                {
                    Console.Write("Enter item quantity: ");
                    string checkQuantity = Console.ReadLine();
                    if (RegistrationCheckers.IsDigitsOnly(checkQuantity))
                    {
                        quantity = int.Parse(checkQuantity);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter digits only.");
                    }
                }

                int itemPrice = int.Parse(parts[1].Trim());
                int bill = itemPrice * quantity;
                totalBill += bill;

                Console.WriteLine($"\nItem Name: {itemName}");
                Console.WriteLine($"Item Quantity: {quantity}");
                Console.WriteLine($"Item Price: {itemPrice}");
                Console.WriteLine($"Current Bill: {bill:C}");
                break;
            }
        }

        if (!itemFound)
        {
            Console.WriteLine("Item is not on the list. Please try again!");
        }

        while (true)
        {
            Console.Write("\nDo you want to buy anything else? (y/n): ");
            ans = Console.ReadLine();
            if (ans.Equals("y" , StringComparison.OrdinalIgnoreCase) || ans.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter 'Y' or 'N' only!");
            }
        }

    } while (ans.Equals("y", StringComparison.OrdinalIgnoreCase));

    Console.WriteLine($"\nYour Total Bill: {totalBill}");
    Console.WriteLine($"Thank you for coming to {restaurant}.");
}
    }
}