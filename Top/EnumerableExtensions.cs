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
            
            IEnumerable<T> reverseValues = input.Reverse();
            decimal finalIndex = Math.Ceiling(input.Count() * x / 100m);
            IEnumerable<T>? output = reverseValues.Take((int)finalIndex);

            return output;
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> input, int x, Func<T, int> selector)
        {
            if (x < 1 || x > 100) throw new ArgumentException("The value must be in the range from 1 to 100!");

            IEnumerable<T> reverseValues = input.OrderByDescending(selector);
            decimal finalIndex = Math.Ceiling(input.Count() * x / 100m);
            IEnumerable<T>? output = reverseValues.Take((int)finalIndex);

            return output;
        }
    }
}
