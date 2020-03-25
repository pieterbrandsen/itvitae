using System;

namespace WaterVerbuik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel water gebruikt U per jaar? Voer alleen het getal in per m3");
            int waterGebruik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welk tarief heeft U? kies uit 0,1,3");
            int tariefSoort = Convert.ToInt32(Console.ReadLine());

            int tarief1Vast = 100;
            double tarief1Los = 0.25;
            int tarief2Vast = 75;
            double tarief2Los = 0.38;

            double tarief1 = (tarief1Los * waterGebruik) + tarief1Vast;
            double tarief2 = (tarief2Los * waterGebruik) + tarief2Vast;
            Double tarief = 0;

            if (tariefSoort == 1)
            {
                tarief = tarief1;
            }
            if (tariefSoort == 2)
            {
                tarief = tarief2;
            }
            if (tariefSoort == 0)
            {
                if (tarief1 > tarief2)
                {
                    tarief = tarief2;
                }
                else
                {
                    tarief = tarief1;
                }
            }

            Console.WriteLine("U moet " + tarief + " Euro betalen.");
            Console.ReadKey();
        }
    }
}
