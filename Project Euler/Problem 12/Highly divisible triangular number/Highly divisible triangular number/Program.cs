using System;
using System.Collections.Generic;

namespace Highly_divisible_triangular_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many divisors do you wanna have for the triangular number?");
            int minimumDivisors = Convert.ToInt32(Console.ReadLine());

            int number = 0;
            int i = 1;
            while (numberOfDivisors(number) < minimumDivisors)
            {
                number += i;
                i++;
            }
            static int numberOfDivisors(int input)
            {
                int totalDivisors = 0;
                int sqrt = (int)Math.Sqrt(input);

                for (int i = 1; i <= sqrt; i++)
                {
                    if (input % i == 0)
                    {
                        totalDivisors += 2;
                    }
                }
                if (sqrt * sqrt == input)
                {
                    totalDivisors--;
                }

                return totalDivisors;
            }
            Console.WriteLine("The first number with " + minimumDivisors + " is " + number);
            Console.ReadKey();
        }
    }
}
