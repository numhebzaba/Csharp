using System;

namespace week11
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("sum = {0}",sum);
            Add(2);
            Console.WriteLine("sum = {0}",sum);
            Console.WriteLine("y = {0}", y);
        }
        static void Add(int y)
        {
            sum += y;
        }
    }
}
