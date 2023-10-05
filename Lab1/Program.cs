
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad3();
            Console.ReadLine();
        }
        static void Zad1()
        {
            Console.Write("Wpisz liczbę: ");
            int x = int.Parse(Console.ReadLine());
            if (x%2==0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
            
        }
        static void Zad2()
        {
            Console.Write("Wpisz n: ");
            int n = int.Parse(Console.ReadLine());
            if (n>1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i%2==0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static void Zad3()
        {
            Console.WriteLine("Które zadanie chcesz zobaczyć");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: Zad1(); break;
                case 2: Zad2(); break;
                case 4:
                    Console.Write("Wpisz n: ");
                    int n = int.Parse(Console.ReadLine());
                    Zad4(n);
                    break;
                case 5: Zad5(); break;
                case 6: Zad6(); break;
                default:
                    Console.WriteLine("Wybierz zadanie z puli od 1 do 6");
                    break;
                    
            }

        }
        static int Zad4(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Zad4(n - 1);
        }
        static void Zad5()
        {
            Random rnd = new Random();
            int computerChoice = rnd.Next(0, 10);
            int input;
            int count=0;
            do
            {
                Console.Write("Zgadnij liczbę: ");
                input = int.Parse(Console.ReadLine());
                if (input > computerChoice)
                {
                    Console.WriteLine("Wieksza");
                }
                else if (input < computerChoice)
                {
                    Console.WriteLine("Mniejsza");
                }
            }
            while (input != computerChoice);
                Console.WriteLine($"Zgadłeś, liczbs to:{computerChoice}, za {count} razem");
        }
        static void Zad6()
        {
            Console.WriteLine("Wybierz 1 z opcji:\n1.celcjusz na farenheity\t2.farenheit na Celcjusza\t3.metr na cm");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Write("Podaj temp w stopniach Celcjusza: ");
                    var inputt = int.Parse(Console.ReadLine());
                    Console.WriteLine($"W farenheitach to {inputt*(9/5)+32}");
                    break;
                default:
                    Console.WriteLine("Wybierz jedną z dostępnych opcji");
                    break;
            }
        }
    }

}
