using System;

namespace Warehouse
{ 
    class Program
{
        //Stała
        public const string FILE_NAME = "X:\\ImportFile.ods";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Check Item");
            Console.WriteLine("Press 1, 2, 3...");

            string operation = Console.ReadLine();

            Console.WriteLine($"You have chosen option {operation}");

            int chosenOperation = 0;

            Int32.TryParse(operation, out chosenOperation);

            Console.WriteLine("Select item category");
            Console.WriteLine("1. Grocery");
            Console.WriteLine("2. Clothing");
            Console.WriteLine("3. Electronics");

            string category = Console.ReadLine();

            ItemTypes chosenCategory;

            Enum.TryParse(category, out chosenCategory);


            int a = 5;
            int b = a;

            Console.WriteLine(a); //5
            Console.WriteLine(b); //5

            b = 50;

            Console.WriteLine(a); //5
            Console.WriteLine(b); //50

            Item item = new Item() { Id = 1, Name = "Apple" };
            Item item2 = item;

            Console.WriteLine(item.Name); //Apple
            Console.WriteLine(item2.Name); //Apple

            item2.Name = "Watermelon";

            Console.WriteLine(item.Name); //Apple
            Console.WriteLine(item2.Name); //Watermelon

        }
    }
}