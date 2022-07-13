namespace Zadanie5
{
    class program
    {
        static void Main(string[] args)
        {
            //Kolor tekstu dla lepszego wyglądu
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Wczytanie pliku tekstowego z imionami
            var imiona = File.ReadAllLines(@"names.txt");


            //Wyświetlenie 246-tego elementu z listy imion
            void Element()
            {
                var index = imiona.ElementAt(246);
                Console.WriteLine($"Elementem 246 z listy jest: {index}");
            }
            //Wyświetlenie osób o imieniu "Anna"
            void Anna()
            {
                Console.WriteLine("\n\nOsoby o imieniu Anna:\n");
                foreach (var name in imiona)
                {
                    if (name.Contains("Anna"))
                    {
                        Console.WriteLine(name);
                    }
                }
            }
            Element();
            Anna();
            Console.ReadKey();
        }
    }
}

