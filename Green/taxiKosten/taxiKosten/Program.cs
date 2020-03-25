using System;

namespace taxiKosten
{
    class Program
    {
        static void Main(string[] args)
        {
            double ritprijs;

            string dag;
            string beginTijd;
            string eindTijd;
            double km;

            Console.WriteLine("Welke dag begint de rit?");
            dag = Console.ReadLine().ToLower();
            Console.WriteLine("Wat is de begintijd van de rit? Voer in als xx:xx");
            beginTijd = Console.ReadLine();
            Console.WriteLine("Wat is de eindtijd van de rit? Voer in als xx:xx");
            eindTijd = Console.ReadLine(); 
            Console.WriteLine("Hoeveel kilometers is de rit?");
            km = Convert.ToDouble(Console.ReadLine());

            string[] begin = beginTijd.Split(':');
            string[] eind = eindTijd.Split(':');

            int beginUur = Convert.ToInt32(begin[0]);
            int beginMinuut = Convert.ToInt32(begin[1]);
            int eindUur = Convert.ToInt32(eind[0]);
            int eindMinuut = Convert.ToInt32(eind[1]);

            int totaalMin = 0;
            double minPrijs = 0;
            double spitsMin = 0;
            double buitenSpitsMin = 0;

            if (beginUur < eindUur)
            {
                totaalMin = (eindUur * 60 + eindMinuut) - (beginUur * 60 + beginMinuut);

                if (beginUur > 8 && beginUur < 18)
                {
                    if (eindUur > 8 && eindUur < 18)
                        buitenSpitsMin = totaalMin;
                    else if (eindUur <= 8 || eindUur >= 18)
                    {
                        buitenSpitsMin = (beginUur * 60 + beginMinuut) - (18 * 60);
                        spitsMin = totaalMin - buitenSpitsMin;
                    }
                }
                else
                {
                    if (beginUur < 8 || beginUur > 18)
                        spitsMin = totaalMin;
                    else if (beginUur >= 8 && beginUur <= 18)
                    {
                        spitsMin = (8 * 60) - (eindUur * 60 + eindMinuut);
                        buitenSpitsMin = totaalMin - spitsMin;

                    }
                }
            }

            minPrijs = 0.25 * buitenSpitsMin + 0.45 * spitsMin;
            ritprijs = km + minPrijs;

            if (dag == "vrijdag" || dag == "zaterdag" || dag == "zondag" || dag == "maandag")
            {

                if (dag == "vrijdag")
                {
                    if (beginUur >= 22)
                        ritprijs = ritprijs * 1.15;
                }
                else if (dag == "maandag")
                {
                    if (beginUur <= 7)
                        ritprijs = ritprijs * 1.15;
                }
                else
                    ritprijs = ritprijs * 1.15;
                    
            }


            Console.WriteLine("De rit gaat: " + ritprijs + " euro kosten.");
            Console.ReadKey();

        }
    }
}
