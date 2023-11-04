using System;

class Program
{
    static void Main(string[] args)

    {
        //For parts 1 and 2;
        //Console.Write("What is the magic number? ");
        //int magic = int.Parse(Console.ReadLine());
            
        // Part 3; random number
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;
        
        while (guess != magic)

        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        }

    }
}