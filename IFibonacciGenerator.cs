namespace FibonacciSeq
{
    public interface IFibonacciGenerator
    {
        //Generate the fibonacci sequence
        object GenerateFibonacci(int range);
        //Print out all values from range 
        void FibFrom(int start);
        //Print out the value of nth in the sequence 
        void NthNumber(int nth);
    }
}