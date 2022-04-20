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
            
            for (int i = 0; i < numberOfDiceRolls; i++)
            {
                Console.WriteLine(r1.Next(1,7));
            }
                
            
        }

    }
}
