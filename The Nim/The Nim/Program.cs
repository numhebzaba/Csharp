using System;

namespace The_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number of box in tank1 ");
            int boxIntank1 = int.Parse(Console.ReadLine());
            Console.Write("input number of box in tank2 ");
            int boxIntank2 = int.Parse(Console.ReadLine());
            Console.Write("input number of box in tank3 ");
            int boxIntank3 = int.Parse(Console.ReadLine());

            int turnCount = 0;

            while(boxIntank1 != 0 || boxIntank2 != 0 || boxIntank3 != 0)
            {
                Console.WriteLine("Select tank");
                int tankNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("number of removing ");
                int numberOfRemoving = int.Parse(Console.ReadLine());
                turnCount++;

                switch (tankNumber)
                {
                    case 1:
                        boxIntank1 -= numberOfRemoving;
                        Console.WriteLine("The number of boxes left {0},{1},{2}",boxIntank1,boxIntank2,boxIntank3);
                        break;
                    case 2:
                        boxIntank2 -= numberOfRemoving;
                        Console.WriteLine("The number of boxes left {0},{1},{2}", boxIntank1, boxIntank2, boxIntank3);
                        break;
                    case 3:
                        boxIntank3 -= numberOfRemoving;
                        Console.WriteLine("The number of boxes left {0},{1},{2}", boxIntank1, boxIntank2, boxIntank3);
                        break;
                }
            }
            if (turnCount % 2 == 0)
            {
                Console.WriteLine("The winner is A ");
            }
            else
            {
                Console.WriteLine("The winner is B ");
            }

        }
    }
}
