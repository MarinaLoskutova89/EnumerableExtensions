using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> input, int x)
        {
            if (x < 1 || x > 100) throw new ArgumentException("The value must be in the range from 1 to 100!");
            if (input == null || input.Count() == 0) throw new Exception("A null or empty value was passed!");

            decimal finalIndex = Math.Ceiling(input.Count() * x / 100m);
            IEnumerable<T>? output = input.TakeLast((int)finalIndex);

            return output;
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> input, int x, Func<T, int> selector)
        {
            IEnumerable<T> output = input.Top(x).OrderByDescending(selector);
            return output;
        }
    }
}
