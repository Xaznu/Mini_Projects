using System;
using System.Linq.Expressions;


namespace Lambda
{
    class Program

    {

        static void Main(string[] args)
        {
            var a = 10;
            Expression<Func<int>> sum2 = () => 1 + a + 3 + 4;
            Func<int> delg3 = sum2.Compile();
            Console.WriteLine($"Wynik wynosi: {delg3()}");
        }
    }
}
