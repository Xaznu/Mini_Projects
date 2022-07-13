using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadanie6
{

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> definition = new SortedDictionary<string, string>
            {
                {"Patrycja Walczak", "111-111-111\n"},
                {"Florentyna Ostrowska", "222-222-222"},
                {"Aleksy Baranowski", "333-333-333"},
                {"Oksana Sikora", "444-444-444"},
                {"Kryspin Pietrzak", "555-555-555"},
                {"Lucjan Górski", "666-666-666"},
                {"Florencja Wiśniewska", "777-777-777"},
                {"Alojzy Wojciechowski", "888-888-888"},
                {"Emilia Sikorska", "999-999-999"},
                {"Kordian Stępień", "000-000-000"}
            };
            do
            {
                Console.WriteLine("Wybierz opcję: \n\n [w] Wyświetlanie całej książki telefonicznej: \n [s] Szukanie po nazwisku i imieniu: \n [a] Szukanie po numerze telefonu: \n [d] Dodawanie nowego wpisu do książki: \n ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                if (keyInfo.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\nWprowadź imię i nazwisko: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("\nWprowadź numer telefonu (xxx-xxx-xxx): ");
                    string explanation = Console.ReadLine();

                    definition[name] = explanation;
                }

                else if (keyInfo.Key == ConsoleKey.W)
                {
                    foreach (KeyValuePair<string, string> def in definition)
                    {
                        Console.WriteLine($"{def.Key}: {def.Value}");
                    }
                }

                else if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine("\nWprowadz numer telefonu do wyszukania xxx-xxx-xxx");
                    string number = Console.ReadLine();
                    if (definition.ContainsValue(number))
                    {
                        Console.WriteLine($"\nZnaleziono numer telefonu: {number}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nNie znaleziono takiego numeru telefonu\n\n");
                    }
                }
                else if (keyInfo.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadz imię i nazwisko do wyszukania\n");
                    string name = Console.ReadLine();
                    if (definition.ContainsKey(name))
                    {
                        Console.WriteLine($"\nZnaleziono taką osobę: {name}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nNie znaleziono takiej osoby\n");
                    }
                }

                else

                {
                    Console.WriteLine("Czy chcesz wyjść z programu [t] - tak, [n] - nie");
                    if (Console.ReadKey().Key == ConsoleKey.T)
                    {
                        break;
                    }
                }
            }

            while (true);
        }
    }
}

