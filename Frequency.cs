using System;
using System.Collections.Generic;
using System.Linq;

namespace frequency
{
    class Frequency
    {
        private readonly Random _random = new Random();

        public int[] GenerateArray()
        {
            var _integerArray = Enumerable
                .Repeat(0, 100)
                .Select(i => _random.Next(1, 10))
                .ToArray();

            return _integerArray;
        }

        public Dictionary<int, int> FindFrequencies(int[] integerArray)
        {
            var frequencies = new Dictionary<int, int>();

            foreach (int x in integerArray)
            {
                if (frequencies.ContainsKey(x))
                {
                    frequencies[x]++;
                }
                else
                {
                    frequencies.Add(x, 1);
                }
            }

            return frequencies;
        }

        public void PrintResults(Dictionary<int, int> frequencies)
        {
            foreach (var frequency in frequencies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"Number {frequency.Key} occured {frequency.Value} times");
            }

            Console.WriteLine("");
            var maxValue = frequencies.Values.Max();

            var keys = frequencies
                .Where(x => x.Value == maxValue)
                .Select(x => x.Key);

            var keyString = string.Join(',', keys);
            var outputString = $"The integer/s {keyString} occured {maxValue} times";
            Console.WriteLine($"{outputString}");
        }
    }
}
