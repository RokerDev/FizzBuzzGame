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
            Console.WriteLine("Let's play the FizzBuzz Game. Give me a number:");
            var userInput = game.TakeInput();
            var gameResult = game.Result();
            Console.WriteLine(gameResult);
        }
    }
}
