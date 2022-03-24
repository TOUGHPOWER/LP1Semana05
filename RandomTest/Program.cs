using System;

namespace RandomTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random r1 = new Random();
            Random r2 = new Random();
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next(1,7));
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next(1,7));
        }
    }
}
