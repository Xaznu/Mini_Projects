using System;
using System.Threading;


namespace Zadanie4
{
    class Program
    {
        static string Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string Welcome = "Witamy w menu!\n\n\n\n\n";
            string WcisnijKlawisz = "Wciśnij dowolny klawisz aby wybrać produkty :)";
            Console.SetCursorPosition((Console.WindowWidth - Welcome.Length) / 2, Console.CursorTop);
            Console.WriteLine(Welcome);
            Console.SetCursorPosition((Console.WindowWidth - WcisnijKlawisz.Length) / 2, Console.CursorTop);
            Console.WriteLine(WcisnijKlawisz);
            Console.ResetColor();
            Console.ReadKey();
            Thread.Sleep(150);
            Console.Clear();
            return Welcome;
        }
        struct Produkt
        {
            public string Nazwa;
            public string Jednostka;
            public double Cena;
        }
        public static void Main(string[] args)
        {
            Produkt item1;
            item1.Nazwa = "Chipsy Lays";
            item1.Jednostka = "szt";
            item1.Cena = 4.99;

            Produkt item2;
            item2.Nazwa = "Pączek z marmoladą";
            item2.Jednostka = "szt";
            item2.Cena = 2.35;

            Produkt item3;
            item3.Nazwa = "Cukierki z galaretką";
            item3.Jednostka = "kg";
            item3.Cena = 22.79;

            Produkt item4;
            item4.Nazwa = "Paczka orzechów mieszanych";
            item4.Jednostka = "szt";
            item4.Cena = 11.99;

            Produkt item5;
            item5.Nazwa = "Pomarańcze";
            item5.Jednostka = "kg";
            item5.Cena = 5.99;

            string PrzedstawienieAsortymentu()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"\n1. {item1.Nazwa} \t\t\t {item1.Cena} zł / {item1.Jednostka}" +
                                  $"\n2. {item2.Nazwa} \t\t {item2.Cena} zł / {item2.Jednostka}" +
                                  $"\n3. {item3.Nazwa} \t {item3.Cena} zł / {item3.Jednostka}" +
                                  $"\n4. {item4.Nazwa} \t {item4.Cena} zł / {item4.Jednostka}" +
                                  $"\n5. {item5.Nazwa} \t\t\t {item5.Cena} zł / {item5.Jednostka}\n");
                return "";

            }

            string MenuWyboru()
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Co chcesz zrobić teraz?\n");
                Console.ResetColor();
                Console.WriteLine("\n1. Dodaj kolejne produkty do koszyka.\n2. Przejdź do kasy.\n");
                int KolejnyKrok = int.Parse(Console.ReadLine());
                switch (KolejnyKrok)
                {
                    case 1:
                        Console.Clear();
                        PrzedstawienieAsortymentu();
                        WyborProduktow();
                        break;
                    case 2:
                        Console.Clear();
                        Paragon();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybrałeś zły numer. Spróbuj ponownie\n");
                        return MenuWyboru();
                }

                return "";
            }
            int LiczbaJednostekProduktu1 = 0;
            int LiczbaJednostekProduktu2 = 0;
            double LiczbaJednostekProduktu3 = 0;
            int LiczbaJednostekProduktu4 = 0;
            double LiczbaJednostekProduktu5 = 0;

            string WyborProduktow()
            {
                int NumerProduktu = int.Parse(Console.ReadLine());
                switch (NumerProduktu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"\nWybrano {item1.Nazwa}. \n\nPodaj ilość: ({item1.Jednostka})\n");
                        LiczbaJednostekProduktu1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Dodano {LiczbaJednostekProduktu1} {item1.Jednostka} {item1.Nazwa} do koszyka.\n");
                        MenuWyboru();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"\nWybrano {item2.Nazwa}. \n\nPodaj ilość: ({item2.Jednostka})\n");
                        LiczbaJednostekProduktu2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Dodano {LiczbaJednostekProduktu2} {item2.Jednostka} {item2.Nazwa} do koszyka.\n");
                        MenuWyboru();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"\nWybrano {item3.Nazwa}. \n\nPodaj ilość: ({item3.Jednostka})\n");
                        LiczbaJednostekProduktu3 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Dodano {LiczbaJednostekProduktu3} {item3.Jednostka} {item3.Nazwa} do koszyka.\n");
                        MenuWyboru();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"\nWybrano {item4.Nazwa}. \n\nPodaj ilość: ({item4.Jednostka})\n");
                        LiczbaJednostekProduktu4 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Dodano {LiczbaJednostekProduktu4} {item4.Jednostka} {item4.Nazwa} do koszyka.\n");
                        MenuWyboru();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine($"\nWybrano {item5.Nazwa}. \n\nPodaj ilość: ({item5.Jednostka})\n");
                        LiczbaJednostekProduktu5 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Dodano {LiczbaJednostekProduktu5} {item5.Jednostka} {item5.Nazwa} do koszyka.\n");
                        MenuWyboru();
                        break;
                    default:
                        Console.WriteLine("Wybrałeś zły numer. Spróbuj ponownie");
                        return WyborProduktow();

                }
                return "";
            }
            string Paragon()
            {
                double KosztProduktow1 = LiczbaJednostekProduktu1 * item1.Cena;
                double KosztProduktow2 = LiczbaJednostekProduktu2 * item2.Cena;
                double KosztProduktow3 = LiczbaJednostekProduktu3 * item3.Cena;
                double KosztProduktow4 = LiczbaJednostekProduktu4 * item4.Cena;
                double KosztProduktow5 = LiczbaJednostekProduktu5 * item5.Cena;
                double SumaKoszt = KosztProduktow1 + KosztProduktow2 + KosztProduktow3 + KosztProduktow4 + KosztProduktow5;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nPARAGON FISKALNY\n\n");
                Console.ResetColor();
                if (LiczbaJednostekProduktu1 != 0)
                {
                    Console.WriteLine($"{item1.Nazwa}\t\t\t{LiczbaJednostekProduktu1}{item1.Jednostka}\t\t\t" + Math.Round(KosztProduktow1, 2) + "zł\n");
                }
                if (LiczbaJednostekProduktu2 != 0)
                {
                    Console.WriteLine($"{item2.Nazwa}\t\t{LiczbaJednostekProduktu2}{item2.Jednostka}\t\t\t" + Math.Round(KosztProduktow2, 2) + "zł\n");
                }
                if (LiczbaJednostekProduktu3 != 0)
                {
                    Console.WriteLine($"{item3.Nazwa}\t\t{LiczbaJednostekProduktu3}{item3.Jednostka}\t\t\t" + Math.Round(KosztProduktow3, 2) + "zł\n");
                }
                if (LiczbaJednostekProduktu4 != 0)
                {
                    Console.WriteLine($"{item4.Nazwa}\t{LiczbaJednostekProduktu4}{item4.Jednostka}\t\t\t" + Math.Round(KosztProduktow4, 2) + "zł\n");
                }
                if (LiczbaJednostekProduktu5 != 0)
                {
                    Console.WriteLine($"{item5.Nazwa}\t\t\t{LiczbaJednostekProduktu5}{item5.Jednostka}\t\t\t" + Math.Round(KosztProduktow5, 2) + "zł\n");
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Pieniądze do zapłaty: \t\t\t\t\t" + Math.Round(SumaKoszt, 2) + "zł\n\n\n");
                Console.ResetColor();
                Console.WriteLine("Wciśnij dowolny przycisk by wydrukować paragon..");
                Console.ReadKey();
                Console.Clear();
                return "";
            }
            Welcome();
            PrzedstawienieAsortymentu();
            WyborProduktow();
        }
    }
}