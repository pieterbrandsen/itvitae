using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesProject.ExercisesB
{
    class _003_LargestPrimeFactor
    {
        /*
        Problem #3

        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ?         
        */
        public static void Main()
        {
            long n;
            Console.WriteLine("Enter a number");
            n = (long)Convert.ToDouble(Console.ReadLine());

            //long n = 600851475143;
            StringBuilder result = new StringBuilder();

            if (isPrime(n))
                result.Append(n);
            
            else
            {
                for (long i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        result.Append(i + " * ");
                        n = n / i;
                    }
                }
                result.Append(n);
            }

            Console.WriteLine("{0}", result.ToString());
            Console.ReadKey();


        }

        static bool isPrime (long n)
        {
            for (long i=2; i<n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
