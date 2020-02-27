using System;

namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            static int IsPrime(int number)
            {
                int n = number, m = n / 2, flag = 0;

                for (int i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1;
                        return 0;
                    }
                }
                if (flag == 0)
                {
                    return 1;
                }
                return 0;
            }

            long finalNumber = 0;

            for (int i = 2; i <= 2000000; i++)
            {
                if (IsPrime(i) == 1)
                {
                    finalNumber = finalNumber + i;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("The sum of the primenumbers under 2 Million is: " + finalNumber);
            Console.ReadKey();
        }
    }
}
