using System;

namespace Numbers
{
    public class NumbersUtility
    {
        public int FibonacciLoop(int n)
        {
            if (n < 0) throw new InvalidOperationException("Number must be greater than zero");

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
            if (n < 0) throw new InvalidOperationException("Number must be greater than zero");

            if (n == 0) return 0;  
            if (n == 1) return 1;

            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        public bool IsPrime(int number)
        {
            if (number < 0) throw new InvalidOperationException("Number must be positive.");

            if (number == 0 || number == 1) return false;

            for (var i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
