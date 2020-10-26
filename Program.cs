
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.Title = "Learning Console App";
            mainMenu();
        }


        static void mainMenu()
        {
            Console.WriteLine("Wybierz jedną z funkcji: ");
            Console.WriteLine("1. Wyświetl liczby nieparzyste \n2. Wyświetl liczby podzielne przez 3 lub 5");
            int caseSwitch;
            Int32.TryParse(Console.ReadLine(), out caseSwitch);

            switch (caseSwitch)
            {

                case 1:
                    Console.Clear();
                    oddNumbers();
                    break;
                case 2:
                    Console.Clear();
                    multipliesOf3or5();
                    break;
                default:
                    Console.WriteLine("Oops! Chyba popełniłeś błąd");
                    mainMenu();
                    break;
            }
        }

        static void exitFunc()
        {
            var exit = Console.ReadKey().Key;

            if (exit == ConsoleKey.B)
            {
                Console.Clear();
                mainMenu();
            }
            else if (exit == ConsoleKey.Q)
            {
                Console.WriteLine("\nZamykam konsolę");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nNie ten klawisz!");
                Console.WriteLine("Wróć (b)");
                Console.WriteLine("Wyjdź (q)");
                exitFunc();
            }
        }

        static void oddNumbers()
        {
            // Wyświetlanie liczb niepatrzystych
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine(i++);
                i++;
            }

            Console.WriteLine("Wróć (b)");
            Console.WriteLine("Wyjdź (q)");
            exitFunc();

        }

        static void multipliesOf3or5()
        {
            List<string> list = new List<string>();
            //Wyświetlanie liczb podzielnych przez 3 lub 5
            for (int a = 0; a <= 1000; a++)
            {
                if ((a % 3 == 0) ^ (a % 5 == 0))
                {
                    Console.WriteLine(a);
                    list.Add(a.ToString());
                }
            }
            //Sumowanie liczb z listy
            Console.WriteLine("Suma: " + list.Sum(x => Convert.ToInt32(x)));

            Console.WriteLine("Wróć (b)");
            Console.WriteLine("Wyjdź (q)");
            exitFunc();
        }
    }
}
