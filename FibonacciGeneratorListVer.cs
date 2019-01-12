using System.Collections.Generic;

namespace FibonacciSeq
{
    public class FibonacciGeneratorListVer : IFibonacciGenerator
    {
        /// <summary>
        /// Find the fibonacci sequence and store in a List
        /// </summary>
        /// <param name="Range"></param>
        /// <returns></returns>
        public object GenerateFibonacci(int Range)
        {
            
            List<int> fib = new List<int>();
            fib.Add(1);
            fib.Add(1);
            fib.Add(2);
            
            for (int i = 2; i < Range-1; i++)
            {
                {
                    fib.Add(fib[i-1]+fib[i]);
                }           
            }
          return fib;
        }
        public void FibFrom(int start)
        {
            List<int> fib = (List<int>)GenerateFibonacci(start);
            foreach (var num in fib)
            {
                System.Console.WriteLine($"List method: {num}");
            }
        }
        public void NthNumber(int nth)
        {
            List<int> fib = (List<int>)GenerateFibonacci(nth);
            nth = nth-1;

            System.Console.WriteLine($"List method: {fib[nth]}"); 
        } 
    }
}