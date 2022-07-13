using System;

namespace tablice

{
    class Program
    {
        static void Main(string[] args)


        {
            string[,] zadanie = new string[6, 6]
 {


    {"( % )","( % )","( % )","( # )","( # )","( # )",},
    {"( % )","( % )","( % )","( # )","( # )","( # )",},
    {"( % )","( % )","( % )","( # )","( # )","( # )",},
    {"( * )","( * )","( * )","( + )","( + )","( + )",},
    {"( * )","( * )","( * )","( + )","( + )","( + )",},
    {"( * )","( * )","( * )","( + )","( + )","( + )",},

 };

            for (int x = 0; x < 6; x++)

            {

                //przerwa pomiedzy znakami
                Console.WriteLine("");

                for (int y = 0; y < 6; y++)

                {
                    Console.Write(zadanie[x, y]);
                }
            }

            Console.ReadLine();
        }
    }
}