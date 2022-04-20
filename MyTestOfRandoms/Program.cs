using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            RollDices();
        }

        private static void RollDices()
        {
            Console.WriteLine("Write a number for how many dices you want to roll");
            int numberOfDiceRolls = int.Parse(Console.ReadLine());
            Random r1 = new Random();
            int diceNumber = 0;
            int diceNumberSum = 0;
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                diceNumber = r1.Next(1,7);
                Console.WriteLine($"Dice Number gotten: {diceNumber}");
                diceNumberSum = diceNumberSum + diceNumber; 
            }

            Console.WriteLine($"The Total of the dice numbers gotten is: {diceNumberSum}");



                
            
        }

    }
}
