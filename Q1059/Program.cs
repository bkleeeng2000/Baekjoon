using System;
using System.Collections.Generic;
using System.Linq;

namespace Q1059
{
    class Program
    {
        private static int _resultCount = 0;

        private static List<string> _array = new();
        static void Main(string[] args)
        {
            var totalCount = int.Parse(Console.ReadLine()!);
            var numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            var target = int.Parse(Console.ReadLine()!);

            if (numbers.Contains(target))
            {
                Console.WriteLine(0);
                return;
            }

            var min = numbers.Where(i => i < target).Max();
            var max = numbers.Where(i => i > target).Min();

            // Console.WriteLine($"max : {max}, min :{min}");

            for (var i = min + 1; i <= target; i++)
            {
                for (var j = i + 1; j < max; j++)
                {
                    _array.Add($"{i} {j}");
                    // Console.WriteLine($"{i} {j}");
                    _resultCount++;

                }
            }

            Console.WriteLine(_resultCount);
        }
    }
}