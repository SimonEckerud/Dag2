using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            BästaLag();
            TempKallast();
            TempJämför();
        }

        private static void TempJämför()
        {
            
            Console.WriteLine("Vad är temperaturen i Svedala?");
            double svedalaTemp = int.Parse(Console.ReadLine());


            Console.WriteLine("Vad är temperaturen i Jukkasjärvi?");
            double jukkasTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Vad är det för temperatur i Visby?");
            double visbyTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Medel temperaturen är: "+ MedelTemp(svedalaTemp, jukkasTemp, visbyTemp));

            TempVarmast(svedalaTemp, jukkasTemp, visbyTemp);
        }

        private static void TempVarmast(double xSvedala, double yJukkas, double zVisby)
        {
            if(xSvedala > yJukkas)
            {
                if (xSvedala>zVisby)
                    Console.WriteLine("Det är varmast i Svedala där är det "+xSvedala+" grader");
                else
                    Console.WriteLine("Det är varmast i Visby där är det "+zVisby+" grader");
            }
            else if (yJukkas>zVisby)
                Console.WriteLine("Det är varmast i Jukkasjärvi där är det "+yJukkas+" grader");
            else
                Console.WriteLine("Det är varmast i Visby där är det " + zVisby + " grader");
                
        }

        private static double MedelTemp(double x, double y, double z)
        {
            double medel = (x + y + z) / 3;
            return medel;
        }

        private static void TempKallast()
        {
            Console.WriteLine("Vad är temperaturen i Svedala");
            double svedalaTemp = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Vad är temperaturen i Jukkasjärvi?");
            double jukkasTemp = int.Parse(Console.ReadLine());
            
            if (svedalaTemp>jukkasTemp)
                Console.WriteLine("Det är kallast i Jukkasjärvi där är det "+ jukkasTemp +" grader");
            else
                Console.WriteLine("Det är kallasr i Svedala där är det "+ svedalaTemp + "grader");

        }

        private static int BästaLag()
        {
            string RättSvar = "AIK";
            Console.WriteLine("Vilket är sveriges bästa lag?");
            string lag = Console.ReadLine();

            if (lag == RättSvar)
            {
                Console.WriteLine("Helt rätt!");
                return 1;
            }
            else
                return 0;
                
        }
    }
}
