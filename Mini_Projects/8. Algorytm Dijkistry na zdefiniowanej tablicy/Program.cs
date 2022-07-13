using System;

namespace ConsoleApp3
{


    struct dane
    {
        public int dystans;
        public int poprzednik;
        public bool odwiedzony;
    };
    class Program
    {

        static void Main(string[] args)
        {
            int[,] graph = {

                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },

                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },

                { 0, 8, 0, 7, 0, 4, 4, 0, 2 },

                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },

                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },

                { 0, 0, 3, 0, 10, 0, 2, 0, 0 },

                { 0, 0, 0, 14, 0, 2, 0, 1, 6 },

                { 8, 11, 0, 0, 4, 0, 1, 0, 7 },

                { 0, 0, 2, 0, 0, 0, 6, 7, 0 }

            };
            Console.WriteLine("Liczba wierzchołków grafu wynosi: 9 \n ");
            int wierzcholki = 9;
            Console.WriteLine("Podaj węzeł początkowy");
            int punktStartu = int.Parse(Console.ReadLine());

            dane[] tab = Dijkistra(graph, punktStartu);
            Console.WriteLine("Wezel\tPoprzedzajacy\tDystans");
            for (int i = 0; i < wierzcholki; i++)
            {
                wypiszDane(i, tab[i]);
            }

            void wypiszDane(int i, dane d)
            {
                Console.Write("{0}\t", i);
                if (!d.odwiedzony)
                {
                    Console.Write("nieodwiedzony");
                }
                else
                {
                    if (d.poprzednik == -1)
                    {
                        Console.Write("brak");
                    }
                    else Console.Write("{0}", d.poprzednik);
                    Console.Write("\t{0}", d.dystans);
                }
                Console.WriteLine();
            }

            int szukajMinimum(ref dane[] tab)
            {
                int min = -1;
                int mindist = int.MaxValue;
                for (int i = 0; i < tab.Length; i++)
                {
                    if (!tab[i].odwiedzony && tab[i].dystans < mindist)
                    {
                        min = i;
                        mindist = tab[i].dystans;
                    }
                }
                return min;
            }

            dane[] Dijkistra(int[,] macierz, int start)
            {
                dane[] tab = new dane[macierz.GetLength(0)];
                for (int i = 0; i < macierz.GetLength(0); i++)
                {
                    tab[i].dystans = (i == start) ? 0 : int.MaxValue;
                    tab[i].odwiedzony = false;
                    tab[i].poprzednik = -1;
                }
                int u = start;
                while (u != -1)
                {
                    tab[u].odwiedzony = true;
                    for (int i = 0; i < macierz.GetLength(0); i++)
                    {
                        if (macierz[u, i] > 0 && tab[u].dystans + macierz[u, i] < tab[i].dystans)
                        {
                            tab[i].dystans = tab[u].dystans + macierz[u, i];
                            tab[i].poprzednik = u;
                        }
                    }
                    u = szukajMinimum(ref tab);
                }
                return tab;
            }
        }
    }
}

