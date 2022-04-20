using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            RollDices();
        }

        /// <summary>
        /// Rolls a number of dices depending on what the 
        /// user puts in and then shows the total of the sum of the 
        /// dice numbers gotten
        /// </summary>
        private static void RollDices()
        {
            //Asks the user for the total number of dices to be rolled
            Console.WriteLine("Write a number for how many dices you want to roll");
            int numberOfDiceRolls = int.Parse(Console.ReadLine());
            Random r1 = new Random();
            int diceNumber = 0;
            int diceNumberSum = 0;
            // From 0 until the number OfDicesRolled he will
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                //assign a number from 1 to non-inclusive 7
                diceNumber = r1.Next(1,7);
                //Show the number
                Console.WriteLine($"Dice Number gotten: {diceNumber}");
                //and add it with the number from diceNumberSum
                diceNumberSum = diceNumberSum + diceNumber; 
            }
            //Finally the program displays the total gotten from the diceNumberSum Variable
            Console.WriteLine($"The Total of the dice numbers gotten is: {diceNumberSum}");



                
            
        }

    }
}
