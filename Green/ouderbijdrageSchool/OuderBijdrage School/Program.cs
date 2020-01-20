using System;
using System.Collections.Generic;

namespace taxiKosten
{
    class Program
    {
        static void Main(string[] args)
        {
            string kinderen;
            string datumKinderen = "";
            string ouders = "";
            string datum = "";
            List<string> datums = new System.Collections.Generic.List<string>();

            int totaalBijdrage = 0;
            int kinderenOnder10 = 0;
            int kinderenBoven10 = 0;

            Console.WriteLine("Welke datum is het vandaag, Voer in als xxxx-xx-xx");
            datum = Console.ReadLine();
            Console.WriteLine("Hoeveel kinderen?");
            kinderen = Console.ReadLine();

            int totaalKinderen = Convert.ToInt32(kinderen);
            for (int i = 0; i < totaalKinderen; i++)
            {
                Console.WriteLine($"Datum Kind {i+1}, Voer in als xxxx-xx-xx");
                datums.Add(Console.ReadLine());

            }


            ouders = Console.ReadLine();
            int totaalOuders = Convert.ToInt32(ouders);

            foreach (string s in datums)
            {
                string[] vandaag = datum.Split('-');
                string[] jaar = s.Split('-');

                int jaarVandaag = Convert.ToInt32(vandaag[0]);
                int jaarGeboorte = Convert.ToInt32(jaar[0]);
                int maandVandaag = Convert.ToInt32(vandaag[1]);
                int maandGeboorte = Convert.ToInt32(jaar[1]);
                int dagVandaag = Convert.ToInt32(vandaag[2]);
                int dagGeboorte = Convert.ToInt32(jaar[2]);

                if((jaarVandaag - jaarGeboorte) > 10) // Ouder dan 10
                {
                    kinderenBoven10 = +1;
                }
                if ((jaarVandaag - jaarGeboorte) == 10)
                {
                    if ((maandVandaag - maandGeboorte) < 0)
                    {
                        if ((dagVandaag - dagGeboorte) < 0) // Jonger dan 10
                        {
                            kinderenOnder10 = +1;
                        }
                        if ((dagVandaag - dagGeboorte) >= 0) // Ouder dan 10
                        {
                            kinderenBoven10 = +1;
                        }
                    }
                    if ((maandVandaag - maandGeboorte) == 0)
                    {
                        if ((dagVandaag - dagGeboorte) < 0) // Jonger dan 10
                        {
                            kinderenOnder10 =+ 1;
                        }
                    }
                    if ((maandVandaag - maandGeboorte) > 0) // Ouder dan 10
                    {
                        if ((dagVandaag - dagGeboorte) > 0)
                        {
                            kinderenBoven10 = +1;
                        }
                    }
                }
                if ((jaarVandaag - jaarGeboorte) < 10) // Jonger dan 10
                {
                    kinderenOnder10=+1;
                }
            }

            int kinderenBoven10Bedrag = 0;
            int kinderenOnder10Bedrag = 0;

            if (kinderenOnder10 > 3)
            {
                kinderenOnder10Bedrag = +75;
            }
            if (kinderenOnder10 <= 3)
            {
                kinderenOnder10Bedrag = kinderenOnder10 * 25;
            }
            if (kinderenOnder10 > 2)
            {
                kinderenOnder10Bedrag = +74;
            }
            if (kinderenOnder10 <= 2)
            {
                kinderenOnder10Bedrag = kinderenOnder10 * 37;
            }

            int basisBedrag = 50;

            totaalBijdrage = kinderenBoven10Bedrag + kinderenOnder10Bedrag + basisBedrag;
            if (totaalBijdrage > 150)
            {
                totaalBijdrage = 150;
            }
            if (totaalOuders == 1)
            {
                double totaalBedrag = totaalBijdrage;
                totaalBedrag = (totaalBedrag / 100) * 75;
                totaalBijdrage = Convert.ToInt32(totaalBedrag);
            }
            Console.WriteLine(totaalBijdrage);
            
            Console.ReadKey();

        }
    }
}
