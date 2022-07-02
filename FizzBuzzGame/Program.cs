using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new FizzBuzz();
            var play = true;
            while (play)
            {
                Console.WriteLine("Let's play the FizzBuzz Game. Give me a number:");
                var userInput = game.TakeInput();
                var gameResult = game.Result(userInput);
                Console.WriteLine(gameResult);
                Console.WriteLine("Do you wanna play again. Yes or No");
                play = game.PlayAgain();
            }
        }
    }
}
