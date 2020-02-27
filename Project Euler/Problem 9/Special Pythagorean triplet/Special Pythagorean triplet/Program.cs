using System;

namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = 1000;
            int abc = 0;
            for (int i = finalNumber / 3; i < finalNumber; i++)
            {
                double testNumber = i * i - finalNumber * finalNumber + 2 * finalNumber * i;
                int first2 = (int)Math.Sqrt(testNumber);
                if (first2 * first2 == testNumber)
                {
                    int b = (finalNumber - i + first2) / 2;
                    int a = finalNumber - b - i;
                    abc = a * b * i; break;
                }
            }
            Console.WriteLine(abc);
            Console.ReadKey();
        }
    }
}
