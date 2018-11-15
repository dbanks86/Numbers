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
    }
}
