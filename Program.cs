using System;

namespace FibonacciSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            IFibonacciGenerator arrayVer = new FibonacciSeqArrayVersion();
            IFibonacciGenerator ListVer = new FibonacciGeneratorListVer();
            IFibonacciGenerator LinkedListVer = new FibonacciGeneratorLinkedListVer();

            //Array Verions
            DisplayAllValues(arrayVer, 10);
            NthValue(arrayVer, 10);
            //ListVer
            DisplayAllValues(ListVer, 10);
            NthValue(ListVer, 10);
            //LinkedListVer
            DisplayAllValues(LinkedListVer, 10);
            NthValue(LinkedListVer, 10);


        }
        private static void DisplayAllValues(IFibonacciGenerator fib, int range)
        {
            fib.FibFrom(range);
        }
        private static void NthValue(IFibonacciGenerator fib, int range)
        {
            fib.NthNumber(range);
        }
    }
}
