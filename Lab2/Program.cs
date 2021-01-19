using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Skriv ditt namn: ");
            string namn = Console.ReadLine();
            Console.WriteLine("Hello " + namn +"!");

            int tal1 = GetNumber("Skriv en siffra: ");
            int tal2 = GetNumber("Skriv en siffra: ");

            int sum = Add(tal1,tal2);
            Console.WriteLine("Summan är: " + sum);
           
            int tal3 = GetNumber("Skriv en siffra: ");
            int tal4 = GetNumber("Skriv en siffra: ");
            int tal5 = GetNumber("Skriv en siffra: ");

            double medel = Medel(tal3, tal4, tal5);
            Console.WriteLine("Medelvärdet är: " + medel);


            Console.WriteLine("Mata in ett decimal tal: ");
            double decim = double.Parse(Console.ReadLine());
            double result = Heltal(decim);
            Console.WriteLine("Det närmaste heltalet är: " + result);

        }

        private static int GetNumber(string msg)
        {
            bool correctInput;
            int number;

            do
            {
                Console.WriteLine(msg);
                correctInput = int.TryParse(Console.ReadLine(), out number);
            } while (!correctInput);
            
            return number;
        }

        private static int Heltal(double decim)
        {
            int avrundat = (int)Math.Round(decim, MidpointRounding.AwayFromZero);

            return avrundat;
        }

        private static double Medel(double tal3, double tal4, double tal5)
        {
            double medel = (tal3 + tal4 + tal5) / 3;
            double medelVärde = Math.Round(medel, 2,MidpointRounding.AwayFromZero);
            return medelVärde;         
        }

        private static int Add(int tal1, int tal2)
        {
            int sum = tal1 + tal2;
            return sum;
        }
    }
}
