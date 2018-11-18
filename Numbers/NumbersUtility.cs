using System;
using System.Linq;
using System.Text;

namespace Numbers
{
    public class NumbersUtility
    {
        public int FibonacciLoop(int n)
        {
            if (n < 0) throw new InvalidOperationException(Constants.EXCEPTION_MESSAGE_LESS_THAN_ZERO);

            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        public int FibonacciRecursion(int n)
        {
            if (n < 0) throw new InvalidOperationException(Constants.EXCEPTION_MESSAGE_LESS_THAN_ZERO);

            if (n == 0) return 0;  
            if (n == 1) return 1;

            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        public bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (var i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public long OrderByDigitDescending(long number)
        {
            if (number < 0) throw new InvalidOperationException(Constants.EXCEPTION_MESSAGE_LESS_THAN_ZERO);

            var numbers = number.ToString().ToList();

            StringBuilder sb = new StringBuilder();

            while (numbers.Count > 0)
            {
                char max = numbers[0];

                foreach (var n in numbers)
                {
                    if (n.CompareTo(max) > 0)
                    {
                        max = n;
                    }
                }

                sb.Append(max);
                numbers.Remove(max);
            }

            return long.Parse(sb.ToString());
        }
    }
}
