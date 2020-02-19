using System;
using System.Collections.Generic;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int highNumber = 0;

            for (int i1 = 0; i1 <= 1000; i1++)
            {
                for (int i2 = 0; i2 <= 1000; i2++)
                {
                        
                    int number = i1 * i2;
                    string check = number.ToString();
                    int checkLength = check.Length;
                    if (checkLength == 1)
                    {
                        if (check[0] == check[0])
                        {
                            if (number > highNumber)
                            {
                                highNumber = number;
                            }
                        }
                    }
                    if (checkLength == 2)
                    {
                        if (check[0] == check[1])
                        {
                            if (number > highNumber)
                            {
                                highNumber = number;
                            }
                        }
                    }
                    if (checkLength == 3)
                    {
                        if (check[0] == check[2])
                        {
                            if (number > highNumber)
                            {
                                highNumber = number;
                            }
                        }
                    }
                    if (checkLength == 4)
                    {
                        if (check[0] == check[3])
                        {
                            if (check[1] == check[2])
                            {
                                if (number > highNumber)
                                {
                                    highNumber = number;
                                }
                            }
                        }
                    }
                    if (checkLength == 5)
                    {
                        if (check[0] == check[4])
                        {
                            if (check[1] == check[3])
                            {
                                if (number > highNumber)
                                {
                                    highNumber = number;
                                }
                            }
                        }
                    }
                    if (checkLength == 6)
                    {
                        if (check[0] == check[5])
                        {
                            if (check[1] == check[4])
                            {
                                if (check[2] == check[3])
                                {
                                    if (number > highNumber)
                                    {
                                        highNumber = number;
                                    }
                                }
                            }
                        }
                    }
                    if (checkLength == 7)
                    {
                        if (check[0] == check[6])
                        {
                            if (check[1] == check[5])
                            {
                                if (check[2] == check[4])
                                {
                                    if (number > highNumber)
                                    {
                                        highNumber = number;
                                    }
                                }
                            }
                        }
                    }
                    if (checkLength == 8)
                    {
                        if (check[0] == check[7])
                        {
                            if (check[1] == check[6])
                            {
                                if (check[2] == check[5])
                                {
                                    if (check[3] == check[4])
                                    {
                                        if (number > highNumber)
                                        {
                                            highNumber = number;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (checkLength == 9)
                    {
                        if (check[0] == check[8])
                        {
                            if (check[1] == check[7])
                            {
                                if (check[2] == check[6])
                                {
                                    if (check[3] == check[5])
                                    {
                                        if (number > highNumber)
                                        {
                                            highNumber = number;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (checkLength == 10)
                    {
                        if (check[0] == check[9])
                        {
                            if (check[1] == check[8])
                            {
                                if (check[2] == check[7])
                                {
                                    if (check[3] == check[6])
                                    {
                                        if (check[4] == check[5])
                                        {
                                            if (number > highNumber)
                                            {
                                            highNumber = number;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine("Het hoogste palindroomse cijfer is: " + highNumber);
            Console.ReadKey();
        }
    }
}
