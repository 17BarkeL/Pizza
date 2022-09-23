using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toppings = new List<string> { "Pepperoni", "Margherita", "Ham and pineapple", "Vegetable" };

            string selection = ChooseFrom(toppings);

            Console.ReadLine();
        }

        static string ChooseFrom(List<string> listToChoseFrom)
        {
            string userInput = "";

            List<string> listUppercase = new List<string>();

            foreach (string item in listToChoseFrom)
            {
                listUppercase.Add(item.ToUpper());
            }

            int failedChoices = -1;

            while (!listUppercase.Contains(userInput.ToUpper()))
            {
                failedChoices++;

                if (failedChoices > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Choice not valid");
                    Console.ResetColor();
                }

                Console.WriteLine("Choose from:");

                foreach (string item in listToChoseFrom)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("--------");

                Console.WriteLine("What do you choose?");
                userInput = Console.ReadLine();
                Console.WriteLine("");
            }

            int itemIndex = listUppercase.IndexOf(userInput.ToUpper());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(listToChoseFrom[itemIndex]);
            Console.ResetColor();

            return userInput;
        }
    }
}
