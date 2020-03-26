using System;
using System.Collections.Generic;

namespace kinderBijslag
{
    class Program
    {
        static void Main(string[] args)
        {
            string kinderen;
            string datumKinderen = "";
            string datum = "";
            List<string> datums = new System.Collections.Generic.List<string>();

            int kinderenOnder12 = 0;
            int kinderenVanaf12 = 0;

            int kinderenVanaf12Bedrag = 0;
            int kinderenOnder12Bedrag = 0;

            Console.WriteLine("Welke datum is het vandaag, Voer in als xx-xx-xxxx");
            datum = Console.ReadLine();
            Console.WriteLine("Over hoeveel kinderen gaat het?");
            kinderen = Console.ReadLine();

            int totaalKinderen = Convert.ToInt32(kinderen);
            for (int i = 0; i < totaalKinderen; i++)
            {
                Console.WriteLine($"Geboortedatum Kind {i + 1}, Voer in als xx-xx-xxxx");
                datums.Add(Console.ReadLine());

            }

            foreach (string s in datums)
            {
                string[] vandaag = datum.Split('-');
                string[] jaar = s.Split('-');

                int jaarVandaag = Convert.ToInt32(vandaag[2]);
                int jaarGeboorte = Convert.ToInt32(jaar[2]);
                int maandVandaag = Convert.ToInt32(vandaag[1]);
                int maandGeboorte = Convert.ToInt32(jaar[1]);
                int dagVandaag = Convert.ToInt32(vandaag[0]);
                int dagGeboorte = Convert.ToInt32(jaar[0]);

                if ((jaarVandaag - jaarGeboorte) < 12)
                {
                    kinderenOnder12++;
                }
                if ((jaarVandaag - jaarGeboorte) == 12)
                {
                    if ((maandVandaag - maandGeboorte) < 0)
                    {
                        if ((dagVandaag - dagGeboorte) < 0)
                        {
                            kinderenOnder12++;
                        }
                        if ((dagVandaag - dagGeboorte) >= 0)
                        {
                            kinderenVanaf12++;
                        }
                    }
                    if ((maandVandaag - maandGeboorte) == 0)
                    {
                        if ((dagVandaag - dagGeboorte) < 0)
                        {
                            kinderenOnder12++;
                        }
                    }
                    if ((maandVandaag - maandGeboorte) > 0)
                    {
                        if ((dagVandaag - dagGeboorte) > 0)
                        {
                            kinderenVanaf12++;
                        }
                    }
                }
                if ((jaarVandaag - jaarGeboorte) > 12 && (jaarVandaag - jaarGeboorte) < 18)
                {
                    kinderenVanaf12++;
                }
            }

            kinderenVanaf12Bedrag = kinderenVanaf12*235;
            kinderenOnder12Bedrag = kinderenOnder12*150;

            double totaalBedrag = kinderenOnder12Bedrag + kinderenVanaf12Bedrag;
            if (totaalKinderen > 2)
            {
                if (totaalKinderen == 3) 
                    totaalBedrag = totaalBedrag * 1.02;
                if (totaalKinderen == 4)
                    totaalBedrag = totaalBedrag * 1.02;
                if (totaalKinderen == 5)
                    totaalBedrag = totaalBedrag * 1.03;
                if (totaalKinderen >= 6)
                    totaalBedrag = totaalBedrag * 1.035;
            }





            Console.WriteLine();
            Console.WriteLine("Het totaal te krijgen bedrag is: " + totaalBedrag);

            Console.ReadKey();
        }
    }
}
