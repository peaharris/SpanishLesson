using System;

namespace Quiz2A
{
    class MainClass
    {
        //Write a short C# program (all of your code should be in Main) that does the following:

        //Prompt the user to enter a number.
        //Read in what the user enters.
        //If the user enters "1" or "one", your program will print out the Spanish equivalent - "Uno".
        //If the user entered "2" or "two", your program will print out the Spanish equivalent - "Dos".
        //And so on for "Tres", "Cuatro", and "Cinco".

        public static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 through 5: ");
            string number = Console.ReadLine();
     
            if (number == "one" || number == "1")
            {
                Console.WriteLine("Uno");
            }
            else if (number == "two" || number == "2")
            {
                Console.WriteLine("Dos");
            }
            else if (number == "three" || number == "3")
            {
                Console.WriteLine("Tres");
            }
            else if (number == "four" || number == "4")
            {
                Console.WriteLine("Cuatro");
            }
            else if (number == "five" || number == "5")
            {
                Console.WriteLine("Cinco");
            }
        }
    }
}
