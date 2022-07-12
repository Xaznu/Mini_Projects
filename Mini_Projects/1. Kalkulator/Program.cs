using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char znak;
            Console.WriteLine("Kalkulator podaj 2 liczby a i b aby je obliczyc oraz sposob w jaki chcesz to zrobic!");
            Console.WriteLine("Podaj a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wybierz operacje: '*' - mnozenie  '/' - dzielenie  '+' - " + "dodawanie  '-' - odejmowanie");
            znak = Convert.ToChar(Console.ReadLine());

            switch (znak)
            {
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '/':
                    if (b != 0)
                    {
                        Console.WriteLine(a / b);
                    }
                    else
                    {
                        Console.WriteLine("Nie mozna dzielic przez zero! Nie mozna wykonac zadania!");
                    }
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                default:
                    Console.WriteLine("Podano niewlasciwy znak! Nie mozna wykonac zadania!");
                    break;
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (keyInfo.Key != ConsoleKey.Enter)
                keyInfo = Console.ReadKey();
        }
    }
}