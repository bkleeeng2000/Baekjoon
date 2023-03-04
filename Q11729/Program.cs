using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

/*
 * Hanoi
 */
namespace Q11729
{
    class Program
    {
        private static int _count = 0;
        private static readonly StringBuilder Sb = new();

        static void Main()
        {
            var floor = int.Parse(Console.ReadLine()!);
            Stopwatch time = Stopwatch.StartNew();
            Hanoi(floor, 1, 3, 2);
            Console.WriteLine(_count);
            Console.WriteLine(Sb.ToString());
            time.Stop();
            Console.WriteLine($"time: {time.ElapsedMilliseconds}");
        }

        static void Hanoi(int floor, int from, int to, int via)
        {
            if (floor == 1)
            {
                Move(from, to);
            }
            else
            {
                Hanoi(floor - 1, from, via, to);
                Move(from, to);
                Hanoi(floor - 1, via, to, from);
            }
        }

        static void Move(int from, int to)
        {
            Sb.Append($"{from} {to}");
            Sb.AppendLine();
            _count++;
        }
    }
}