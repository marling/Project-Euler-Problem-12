using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerProblem12
{
    public class Problem12
    {
        public int CalculateTriangleNumber(int input)
        {
            var result = 0;

            for (var i = 1; i <= input; i++)
                result += i;

            return result;
        }

        public List<int> CalculateTriangleNumbers(int maxNumber)
        {
            var result = new List<int>();

            for(var i = 1; i <= maxNumber; i++)
                result.Add(CalculateTriangleNumber(i));

            return result;
        }

        public bool IsNumberADivisor(int naturalNumber, int divisor)
        {
            return naturalNumber % divisor == 0;
        }

        public List<int> CalculateDivisors(int naturalNumber)
        {
            var result = new List<int>();

            var maxNumber = naturalNumber;

            for (var i = 1; i <= maxNumber; i++)
            {
                if (!IsNumberADivisor(naturalNumber, i))
                    continue;

                result.Add(i);

                var newMax = naturalNumber / i;

                if (i != newMax)
                    result.Add(newMax);

                maxNumber = newMax - 1;
            }

            return result.OrderBy(x => x).ToList();
        }

        public int CalculateFirstTriangleByNumberOfDivisors(int divisors)
        {
            var i = 1;

            while (true)
            {
                var r = CalculateTriangleNumber(i);

                var result = CalculateDivisors(r);

                if (result.Count >= divisors)
                    return result.Max();

                i++;
            }
        }
    }
}
