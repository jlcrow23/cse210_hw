using System;

class Program
{
    static void Main(string[] args)
    {
        // //List words
        // List<string> words = newList<string>();
        // //Add words to list
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");
        // //Count words
        // Console.WriteLine(words.Count);
        // //List numbers
        // List<int> numbers = new List<int>();
        // //Refer to library at top
        // using System.Collections.Generic;
        // // Iterate through a list
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        // //Access items by index
        // for (int i = 0; i < words.COunt; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }
        List<int> numbers = new List<int>();
        
        int userNumber = -1;

        while (userNumber != 0)
        {   Console.Write("Enter a list of numbers, type 0 to quit: ");

            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        //Part 2: Average
        float average =((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        //Part 3: Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number is: {max}");
    }
}