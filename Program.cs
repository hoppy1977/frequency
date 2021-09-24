using System;

namespace frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            var _frequency = new Frequency();

            var integerArray = _frequency.GenerateArray();
            var frequencies = _frequency.FindFrequencies(integerArray);
            _frequency.PrintResults(frequencies);

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
