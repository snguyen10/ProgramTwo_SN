using System;

namespace ProgramTwo_SN
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerIterator;

            Console.WriteLine("Input an integer between 1 and 100");
            /* Use try catch to invalidate bad input*/
            try
            {
                /* Read user input as string then establish it as
                 * Integer value */
                string userInput = Console.ReadLine();
                integerIterator = int.Parse(userInput);
                /* Start for loop at 1 and count through each interaction from 1*/
                for (int i = 1; i <= integerIterator; i++)
                {
                    Console.WriteLine("You have entered " + userInput + ". This the current integer value in the loop: " + i.ToString() + ".");
                }
            }
            /* End of try catch statement */
            catch
            {
                Console.WriteLine("Make sure you enter an integer from 1 to 100.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadKey(true);
            }
        }
    }
}
