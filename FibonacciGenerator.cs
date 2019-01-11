using System;
using System.Collections.Generic;

namespace FibonacciSeq
{
    /// <summary>
    /// Fibonacci is 1,1,2,3,5,8 so the math is n=n-1+n where n is the position in the stack
    /// </summary>
    public static class Fibonacci
    {
        public static int[] GenerateFibonacciArray(int range)
        {
            int[] fib = new int[range];
            if(range >= 1)
            fib.SetValue(1, 0);
            if(range >= 2)
            fib.SetValue(1, 1);
            if(range >= 3)
            fib.SetValue(2, 2);
            
            int index = 3;
            for (int i = 2; i < range-1; i++)
            {
                {
                    fib.SetValue(fib[i-1]+fib[i], index);
                    index++;
                }           
            }
          return fib;
        }

        public static void FibFromToReturnArray(int start)
        {
            int[] fib = GenerateFibonacciArray(start);
            foreach (var num in fib)
            {
                System.Console.WriteLine($"Int array method: {num}");
            }
        }
        public static void NthNumberArray(int nth)
        {
            int[] fib = GenerateFibonacciArray(nth);

            nth = nth-1;
            System.Console.WriteLine($"Int array: {fib[nth]}"); 
        } 
        /// <summary>
        /// Find the fibonacci sequence and store in a List
        /// </summary>
        /// <param name="Range"></param>
        /// <returns></returns>
        private static List<int> GenerateFibonacciList(int Range)
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
        public static void FibFromToReturnList(int start)
        {
            List<int> fib = GenerateFibonacciList(start);
            foreach (var num in fib)
            {
                System.Console.WriteLine($"List method: {num}");
            }
        }
        public static void NthNumberReturnList(int nth)
        {
            List<int> fib = GenerateFibonacciList(nth);
            nth = nth-1;

            System.Console.WriteLine($"List method: {fib[nth]}"); 
        } 
        /// <summary>
        /// Find the fibonacci sequence and store in a List
        /// </summary>
        /// <param name="Range"></param>
        /// <returns></returns>
        private static LinkedList<int> GenerateFibonacciLinkedList(int Range)
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
        public static void FibFromToReturnLinkedList(int start)
        {
            LinkedList<int> fib = GenerateFibonacciLinkedList(start);
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
        public static void NthNumberReturnLinkedList(int nth)
        {
            LinkedList<int> fib = GenerateFibonacciLinkedList(nth);
            nth = nth-1;
            LinkedListNode<int> node = FindNodeAtNth(fib.First, nth);
            
            System.Console.WriteLine($"LinkedList method: {node.Value}"); 
        } 
    }
}