using System;
using Anagrams.core.Contracts;

namespace Anagrams.core
{
    class Program
    {
        private static IAnagramCounter _anagramCounter = new BadAnagramCounter();
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
