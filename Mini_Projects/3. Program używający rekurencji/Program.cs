using System;

namespace Zadanie3
{
	class Program
	{
		static bool pierwsza(int a, int o = 2)
		{
			return (o <= Math.Sqrt(a)) ? (a % o == 0) ? false : pierwsza(a, ++o) : true;
		}

		static void Main(string[] args)
		{
			int a;
			Console.WriteLine("Wpisz liczbe do sprawdzenia czy jest liczba pierwsza");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Liczba {0} {1}jest pierwsza", a, (pierwsza(a) ? "" : "nie "));
			Console.ReadKey();
		}
	}
}