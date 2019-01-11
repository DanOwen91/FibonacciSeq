using System;

namespace FibonacciSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use an int[] to store results
            Fibonacci.FibFromToReturnArray(10);
            Fibonacci.NthNumberArray(11);

            //Use a list to store results
            Fibonacci.FibFromToReturnList(10);
            Fibonacci.NthNumberReturnList(10);

            //Use a linkedlist to store results
            Fibonacci.FibFromToReturnLinkedList(10);
            Fibonacci.NthNumberReturnLinkedList(10);
        }
    }
}
