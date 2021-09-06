using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y;
            if (x == 1 || x == 2)
            {
                y = 2 * x;

            }
            else if (x >= 5 && x <= 8)
            {
                y = 3 * x + 2;

            }
            else if (x == 3 || (x >= 9 && x <= 12))
            {
                y = Math.Abs(x);
            }
            else if (x == 4)
            {
                y = (int)(Math.Pow(x, 2) - 5);
            }
            else { y = x; }
        }      
    }
}
