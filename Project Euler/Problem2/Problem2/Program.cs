using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            int fn_1 = 1;
            int fn_2 = 1;

            while (fn_1 <= 4000000)
            {
                if (fn_1 % 2 == 0)
                    result += fn_1;

                int fn_2Aux = fn_1;
                fn_1 = fn_2 + fn_1;
                fn_2 = fn_2Aux;
            }

            Console.WriteLine(
                "Sum of even fibonacci numbers below 4 million is: " + result);

            Console.ReadKey();
        }
    }
}
//4613732
