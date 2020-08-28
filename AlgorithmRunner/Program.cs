using System;
using Ackerman;

namespace AlgorithmRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ackerman.AckermanFunction.Execute(4, 0));
            Console.WriteLine(Ackerman.AckermanFunction.Execute(3, 2));
            Console.WriteLine(Ackerman.AckermanFunction.Execute(3, 4));
            //Console.WriteLine(Ackerman.AckermanFunction.Execute(4, 1)); - Stack overflow. - haha not expected
            Console.ReadLine();
        }
    }
}
