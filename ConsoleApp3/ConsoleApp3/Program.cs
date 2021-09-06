using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fire = 1;
            int water = 2;
            int wind = 4;
            int stone = 8;
            int x = int.Parse(Console.ReadLine());
            if (x <= 15)
            {
                if (x >= stone)
                {
                    x = x - stone;
                    Console.WriteLine("stone");

                    if (x >= wind)
                    {
                        x = x - wind;
                        Console.WriteLine("wind");

                        if (x >= water)
                        {
                            x = x - water;
                            Console.WriteLine("water");

                            if (x == fire)
                            {
                                x = x - fire;
                                Console.WriteLine("fire");
                            }

                        }
                    }
                }

            }
        }
    }
}
