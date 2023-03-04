using System;

namespace Q2447
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine()!);
            if (num % 3 != 0) return;
            Solve(num);
        }

        private static void Solve(int num)
        {
            for (var i = 0; i < num; i++)
            {
                for (var j = 0; j < num; j++) Star(num, i, j);
                Console.WriteLine();
            }
        }

        private static void Star(int num, int i, int j)
        {
            if (i / num % 3 == 1 && j / num % 3 == 1)
                Console.Write(" ");
            else if (num / 3 == 0)
                Console.Write("*");
            else
                Star(num / 3, i, j);
        }
    }
}