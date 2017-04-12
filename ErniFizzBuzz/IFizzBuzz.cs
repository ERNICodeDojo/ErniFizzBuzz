using System.Collections.Generic;

namespace ErniFizzBuzz
{
    public interface IFizzBuzz
    {
        /// <summary>
        /// Gets the fizz buzz.
        /// </summary>
        /// <param name="total">The total.</param>
        /// <returns>IEnumerable{string}</returns>
        IEnumerable<string> GetFizzBuzz(int total);
    }
}
