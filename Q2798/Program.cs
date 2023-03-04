using System;
using System.Linq;

/*
 * Black Jack
 */

namespace Q2798
{
    class Program
    {
        private static int _max;
        private static int _target;
        private static int[] _cardList = Array.Empty<int>();

        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            _target = input[1];

            _cardList = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            BlackJack(_cardList.Length);

            Console.WriteLine(_max);
        }

        private static void BlackJack(int size)
        {
            for (var i = 0; i < size; i++)
            for (var j = 0; j < size; j++)
            {
                if (j == i) continue;
                for (var k = 0; k < size; k++)
                {
                    if (k == j || k == i) continue;
                    var sum = _cardList[i] + _cardList[j] + _cardList[k];
                    if (sum > _max && _target >= sum) _max = sum;
                }
            }
        }
    }
}