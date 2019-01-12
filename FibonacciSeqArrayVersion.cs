namespace FibonacciSeq
{
    public class FibonacciSeqArrayVersion : IFibonacciGenerator
    {
        public object GenerateFibonacci(int range)
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

        public void FibFrom(int start)
        {
            int [] fib = (int[])GenerateFibonacci(start);
            foreach (var num in fib)
            {
                System.Console.WriteLine($"Int array method: {num}");
            }
        }
        public void NthNumber(int nth)
        {
            int[] fib = (int[])GenerateFibonacci(nth);

            nth = nth-1;
            System.Console.WriteLine($"Int array: {fib[nth]}"); 
        }

       
    }
}