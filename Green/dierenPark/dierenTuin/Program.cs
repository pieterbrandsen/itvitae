using System;
using System.Collections.Generic;

namespace dierenTuin
{
    class Program
    {
        static void Main(string[] args)
        {

            string personen;
            string datum = "";
            List<string> datums = new System.Collections.Generic.List<string>();

            int personenBoven65 = 0;
            int personenVolwassen = 0;
            int personenKinderen = 0;

            Console.WriteLine("Welke datum is het vandaag, Voer in als xx-xx-xxxx");
            datum = Console.ReadLine();
            Console.WriteLine("Hoeveel personen?");
            personen = Console.ReadLine();

            int totaalPersonen = Convert.ToInt32(personen);
            for (int i = 0; i < totaalPersonen; i++)
            {
                Console.WriteLine($"Datum Persoon {i + 1}, Voer in als xx-xx-xxxx");
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

                if ((jaarVandaag - jaarGeboorte) >= 65)
                {
                    personenBoven65++;
                }
                else if ((jaarVandaag - jaarGeboorte) >= 18 && (jaarVandaag - jaarGeboorte) < 65)
                {
                    personenVolwassen++;
                }
                else if ((jaarVandaag - jaarGeboorte) < 18)
                {
                    personenKinderen++;
                }
            }


            int kosten = 0;
            if (personenBoven65 == 1)
            {
                kosten = kosten + 26;
            } 
            else if (personenBoven65 == 2)
            {
                kosten = kosten + 65;
            }
            else if (personenBoven65 > 2)
            {
                Console.WriteLine("Voer minder dan 2 personen ouder dan 65 in");
            }
            else if (personenVolwassen == 1)
            {
                if (personenKinderen == 0)
                {
                    kosten = kosten + 30;
                }
                else if (personenKinderen == 1)
                {
                    kosten = kosten + 71;
                }
                else if (personenKinderen == 2)
                {
                    kosten = kosten + 82;
                }
                else if (personenKinderen > 2)
                {
                    kosten = kosten + 71;
                    kosten = kosten + (personenKinderen - 2) * 11;
                }
            }
            else if (personenVolwassen == 2)
            {
                if (personenKinderen == 0)
                {
                    kosten = kosten + 61;
                }
                else if (personenKinderen == 1)
                {
                    kosten = kosten + 71;
                }
                else if (personenKinderen == 2)
                {
                    kosten = kosten + 82;
                }
                else if (personenKinderen > 2)
                {
                    kosten = kosten + 71;
                    kosten = kosten + (personenKinderen - 2) * 11;
                }
            }
            else if (personenVolwassen > 2)
            {
                Console.WriteLine("Voer minder dan 2 volwassenen in");
            }

            if (kosten > 0)
            {
                Console.WriteLine($"Het abonnement zal {kosten} euro gaan kosten.");
            }
            Console.ReadKey();
        }
    }
}
