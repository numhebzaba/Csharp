﻿using System;

namespace week9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(1995,300,99));
        }
        static int Max(int x, int y, int z)
        {
            if (x > y && x > z)
                return x;
            else if (y > x && y > z)
                return y;
            else
                return z;
        }
    }
}
