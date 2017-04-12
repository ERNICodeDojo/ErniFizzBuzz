using System;
using System.Collections.Generic;
using System.Text;

namespace ErniFizzBuzz
{
    /// <summary>
    /// FizzBuzz.
    /// </summary>
    /// <seealso cref="ErniFizzBuzz.IFizzBuzz" />
    public class FizzBuzz : IFizzBuzz
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string Whizz = "Whizz";

        private readonly StringBuilder _stringBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzz"/> class.
        /// </summary>
        public FizzBuzz()
        {
            _stringBuilder = new StringBuilder();
        }

        /// <summary>
        /// Gets the fizz buzz.
        /// </summary>
        /// <param name="total">The total.</param>
        /// <returns>IEnumerable{string}</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public IEnumerable<string> GetFizzBuzz(int total)
        {
            if (total < 0)
            {
                throw new ArgumentOutOfRangeException($"{total} must be positive");
            }

            var fizzBuzzList = new List<string>();

            for (var i = 1; i <= total; i++)
            {
                this._stringBuilder.Clear();

                if (i % 3 == 0)
                {
                    this._stringBuilder.Append(Fizz);
                }

                if (i % 5 == 0)
                {
                    this._stringBuilder.Append(Buzz);
                }

                if (i % 7 == 0)
                {
                    this._stringBuilder.Append(Whizz);
                }

                if (this._stringBuilder.Length == 0)
                {
                    this._stringBuilder.Append(i);
                }

                fizzBuzzList.Add(this._stringBuilder.ToString());
            }

            return fizzBuzzList;
        }
    }
}
