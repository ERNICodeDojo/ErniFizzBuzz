using System;
using ErniFizzBuzz;

namespace FizzBuzzConsole
{
    /// <summary>
    /// Main
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        private static void Main()
        {
            var fizzBuzz = new FizzBuzzExtended();

            foreach (var line in fizzBuzz.GetFizzBuzz(100))
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
