using System;
using System.Collections.Generic;

namespace _10001st_prime
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

            int primeNumbers = 10500;
            List<int> primeList = new List<int>();
            


            int i = 1;
            while (primeNumbers > 0)
            {
                if (IsPrime(i) == 1)
                {
                    primeList.Add(i);
                    i++;
                    primeNumbers--;
                }
                else i++;
            }

            int[] array = primeList.ToArray();
            Console.WriteLine("The 10.001st prime is: " + array[10001]);
            Console.ReadKey();
        }
    }
}
