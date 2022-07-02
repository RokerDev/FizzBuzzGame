using System;
using System.Collections.Generic;

namespace FizzBuzzGame
{
    class FizzBuzz
    {
        internal int TakeInput()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"I need number between {int.MinValue}...{int.MaxValue}. Try again.");
                    continue;
                }
                return num;
            }
        }

        internal string Result(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
                return num.ToString();
        }

        internal bool PlayAgain()
        {
            var list = new List<string>() { "Yes", "yes", "y", "Y" };
            var userInput = Console.ReadLine();
            if (list.Contains(userInput))
            {
                Console.Clear();
                return true;
            }
            else
                return false;
        }
    }
}