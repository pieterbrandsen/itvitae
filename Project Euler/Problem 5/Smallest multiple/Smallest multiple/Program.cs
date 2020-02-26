using System;
using System.Collections.Generic;
using System.Linq;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = new List<int>();
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            int finalNumber = 1;

            Console.WriteLine("What is the begin number of your LCM?");
            int begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the last number of your LCM?");
            int eind = Convert.ToInt32(Console.ReadLine());

            static int CalcDuplicates(int[] numbers, int searchedNumber)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == searchedNumber)
                        count++;
                }
                return count;
            }
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


            for (int i = begin; i <= eind; i++)
            {
                List<int> steps = new List<int>();
                bool notPrime = true;
                double i2 = i;
                while (notPrime != false)
                {
                    if (IsPrime(Convert.ToInt32(i2)) == 1)
                    {
                        notPrime = false;
                        steps.Add(Convert.ToInt32(i2));

                        int[] array = steps.ToArray();
                        int[] array2 = allNumbers.ToArray();

                        for (int i3 = 1; i3 <= 20; i3++)
                        {
                            if (CalcDuplicates(array, Convert.ToInt32(i3)) > CalcDuplicates(array2, Convert.ToInt32(i3)))
                            {
                                int count = CalcDuplicates(array, Convert.ToInt32(i3)) - CalcDuplicates(array2, Convert.ToInt32(i3));
                                for (int i4 = 0; i4 < count; i4++)
                                    allNumbers.Add(i3);
                            }
                        }
                        break;
                    }
                    else
                    {
                        for (double i3 = 8; i3 >= 0; i3--)
                        {
                            if (i2 / primeNumbers[Convert.ToInt32(i3)] % 1 == 0)
                            {
                                i2 = i2 / primeNumbers[Convert.ToInt32(i3)];
                                steps.Add(primeNumbers[Convert.ToInt32(i3)]);
                                i3 = 8;
                                if (IsPrime(Convert.ToInt32(i2)) == 1)
                                    i3 = -1;
                            }
                        }
                    }
                }
            }


            int[] array3 = allNumbers.ToArray();

            for (int i2 = 0; i2 < array3.Length; i2++)
                finalNumber = finalNumber* array3[i2];

            Console.WriteLine("The LCM of your range is: " + finalNumber);
            Console.ReadKey();
        }
    }
}