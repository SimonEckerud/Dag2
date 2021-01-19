using System;

namespace Dag2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mittTal = 10;
            //Console.WriteLine(mittTal);
            //Console.WriteLine("Hello World!");

            DemoReadKey();
            SwitchKey();
        }

        private static void SwitchKey()
        {
            bool done = false;
            Console.WriteLine("Skriv en sifffra: ");
            string siffra = Console.ReadLine();
            int meny = int.Parse(siffra);

            while (!done)
                
                switch (meny)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                    done = true;
                        break;
                    default:
                        break;
                }
        }

        private static void DemoReadKey()
        {
            ConsoleKeyInfo keyinfo = Console.ReadKey(true);

            if(keyinfo.Key == ConsoleKey.A)
                Console.WriteLine("Du skrev A");
            else
                Console.WriteLine("Du tryckte på en annan tangent");
        }
    }
}
