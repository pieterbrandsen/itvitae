using System;

namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter begin number for the sum square difference");
            int begin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end number for the sum square difference");
            int end = Convert.ToInt32(Console.ReadLine());

            int number1 = 0;
            int number2 = 0;
            for (int i = begin; i <= end; i++)
            {
                number1 = number1 + i;
                number2 = number2 + i * i;
                Console.WriteLine(i);
            }
            number1 = number1 * number1;
            int finalNumber = number1 - number2;

            Console.WriteLine("The difference between the sum of the squares of the first ten natural numbers and the square of the sum is: " + finalNumber);

        }
    }
}
