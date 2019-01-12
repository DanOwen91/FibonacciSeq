using System;
using System.Collections.Generic;

namespace FibonacciSeq
{
    /// <summary>
    /// Fibonacci is 1,1,2,3,5,8 so the math is n=n-1+n where n is the position in the stack
    /// </summary>
    public class FibonacciGeneratorLinkedListVer : IFibonacciGenerator
    {
        /// <summary>
        /// Find the fibonacci sequence and store in a List
        /// </summary>
        /// <param name="Range"></param>
        /// <returns></returns>
        public object GenerateFibonacci(int Range)
        {
            
            LinkedList<int> fib = new LinkedList<int>();
            fib.AddFirst(1);
            fib.AddLast(1);
            fib.AddLast(2);
            
            for (int i = 2; i < Range-1; i++)
            {
                {
                    fib.AddLast(fib.Last.Previous.Value + fib.Last.Value);
                }           
            }
          return fib;
        }
        public void FibFrom(int start)
        {
            LinkedList<int> fib = (LinkedList<int>)GenerateFibonacci(start);
            foreach (var num in fib)
            {
                System.Console.WriteLine($"LinkedList method: {num}");
            }
        }

        private static LinkedListNode<int> FindNodeAtNth(LinkedListNode<int> head, int nth)
        {
            LinkedListNode<int> lastNode = head;
            for (int listLenght = 0; listLenght < nth; listLenght++)
            {
                lastNode = lastNode.Next;
            }
            
            return lastNode;
        }
        public void NthNumber(int nth)
        {
            LinkedList<int> fib = (LinkedList<int>)GenerateFibonacci(nth);
            nth = nth-1;
            LinkedListNode<int> node = FindNodeAtNth(fib.First, nth);
            
            System.Console.WriteLine($"LinkedList method: {node.Value}"); 
        } 
    }
}