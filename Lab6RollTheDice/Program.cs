using System;
using System.Text.RegularExpressions;
namespace Lab6RollTheDice
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                int sides;
                
                Console.WriteLine("\nWelcome to the Grand Circus Casino! Let's roll a pair of dice. How many sides on each of your die would you like?");
                sides = Convert.ToInt32(Console.ReadLine());
                //using rnd method with sides parameter to determine maximum num that can be rolled
                // ints diceOne and diceTwo rep each die
                Random rnd = new Random(sides);
                int diceOne = rnd.Next(sides);
                int diceTwo = rnd.Next(sides);
                
                Console.WriteLine("\nYou've rolled a " + diceOne + " and a " + diceTwo);
                
                //nested do while prompts user to give valid resp otherwise will keep prompting
                do
                {
                    Console.WriteLine("\nWould you like to roll again?");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        // user may exit program due to proper n response
                        Console.WriteLine("\nOK, bye!");
                        break;
                    }
                    if (answer != "y" && answer != "n")
                    {
                        //user has entered neither y nor n triggering loop to prompt again
                        Console.WriteLine("\nOops, please answer 'y' or 'n'");
                    }
                }
                while (answer !="y" && answer !="n");
            }
            while (answer == "y");
            //this do while loop runs as long as user answers y

        }



    }
}
