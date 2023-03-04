using System;
using System.Linq;

namespace Q1037
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            var numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Console.WriteLine(numbers.Min() * numbers.Max());
        }
    }
}