using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private const string Format = "Wartosc Liczby X wynosi";
        int x = 0;
        int y = 0;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Kalkulator();
            Console.ReadKey();
        }
        public void Kalkulator()
        {
            Console.WriteLine("Podaj Cyfre X");
            Task.Delay(1000);
            x = Convert.Toint32(Console.ReadLine());
            Task.Delay(1000);

            Task.Delay(1000);

            Console.WriteLine("Podaj Cyfre Y");
            Task.Delay(1000);
            y = Convert.Toint32(Console.ReadLine());

            Task.Delay(1000);

            Console.WriteLine("Konsolowy kalkulator w C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Wybierz opcje z listy poniżej;");
            Console.WriteLine("\ta - Dodaj");
            Console.WriteLine("\tb - Odejmij");
            Console.WriteLine("\tc - Pomnoz");
            Console.WriteLine("\td - Podziel");
            Console.Write("Wybierz");
            Task.Delay(10000);
                  switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Wynik: {x} + {y} = " + (x + y));
                    break;
                case "b":
                    Console.WriteLine($"Wynik: {x} - {y} = " + (x - y));
                    break;
                case "c":
                    Console.WriteLine($"Wynik: {x} * {y} = " + (x * y));
                    break;
                case "d":
                    Console.WriteLine($"Wynik: {x} / {y} = " + (x / y));
                    break;
            }
        }
    }
}
