using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErniFizzBuzz
{
    /// <summary>
    /// FizzBuzzExtended.
    /// </summary>
    /// <seealso cref="ErniFizzBuzz.IFizzBuzz" />
    public class FizzBuzzExtended : IFizzBuzz
    {
        private static readonly IEnumerable<Tuple<int, string>> FizzBuzzTuple = new List<Tuple<int, string>>
        {
            new Tuple<int, string> (3, "Fizz"),
            new Tuple<int, string> (5, "Buzz"),
            new Tuple<int, string> (7, "Whizz")
        };

        private readonly StringBuilder _stringBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzExtended"/> class.
        /// </summary>
        public FizzBuzzExtended()
        {
            _stringBuilder = new StringBuilder();
        }

        /// <summary>
        /// Gets the fizz buzz.
        /// </summary>
        /// <param name="total">The total.</param>
        /// <returns>
        /// IEnumerable{string}
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public IEnumerable<string> GetFizzBuzz(int total)
        {
            if (total < 0)
            {
                throw new ArgumentOutOfRangeException($"{total} must be positive");
            }

            var fizzBuzzList = new List<string>();

            Func<int, int, bool> isFizzBuzz = (i, fizzBuzzTuple) => i % fizzBuzzTuple == 0;

            for (var i = 1; i <= total; i++)
            {
                this._stringBuilder.Clear();

                var matchingFizzBuzz = FizzBuzzTuple.Where(c => isFizzBuzz(i, c.Item1)).ToList();
                if (matchingFizzBuzz.Any())
                {
                    this._stringBuilder.Append(string.Join(string.Empty, matchingFizzBuzz.Select(c => c.Item2)));
                }
                else
                {
                    this._stringBuilder.Append(i);
                }

                fizzBuzzList.Add(this._stringBuilder.ToString());
            }

            return fizzBuzzList;
        }
    }
}
