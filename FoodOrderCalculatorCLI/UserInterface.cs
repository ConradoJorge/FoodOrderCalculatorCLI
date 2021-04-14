using System;

namespace FoodOrderCalculatorCLI
{
    public class UserInterface
    {
        public static void MainMenu()
        {
            
            while (true)
            {
                const int numberOfOptions = 6; // Number of options available to the user checked in the Order method to produce an error if out of range.

                Console.WriteLine("1. Uber Eats");
                Console.WriteLine("2. Grubhub");
                Console.WriteLine("3. DoorDash");
                Console.WriteLine("4. Postmates");
                Console.WriteLine("5. Direct from the restaurant \n");

                Console.WriteLine(numberOfOptions + ". Exit \n "); // Exit should be the last option in the list.

                var userSelection = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);

                Console.Clear();

                /*
                 * 
                 * 
                 * Add handling for invalid inputs here
                 * 
                 * 
                 */

                if (userSelection == (char)numberOfOptions)
                    break;
                else
                    Order.Input(userSelection, numberOfOptions);
            }
        }

    }
}