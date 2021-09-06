using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //float x;
            //x = float.Parse(Console.ReadLine());
            //if(x>=0)
            //{
            //    Console.WriteLine(x);
            //}
            //if (x < 0)
            //{
            //    Console.WriteLine(-x);
            //}
            //Console.ReadLine();


            //double x;
            //x = double.Parse(Console.ReadLine());

            //if (x <= 5)
            //{
            //    Console.WriteLine(2*x+10);
            //}else if(x<=20 && x> 5)
            //{
            //    Console.WriteLine(Math.Pow(x,2)+10);
            //}
            //else if (x > 20)
            //{
            //    Console.WriteLine(Math.Pow(x, 3) + 10);
            //}
            //Console.ReadLine();



            //Console.Write("Please input N : ");
            //double N = double.Parse(Console.ReadLine());

            //if (N == Math.Round(N))
            //{
            //    Console.WriteLine(N + " is integer.");
            //}if(N != Math.Round(N))
            //{
            //    Console.WriteLine(N + "  is not integer.");
            //}
            //Console.ReadLine();



            Console.Write("Please input X : ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Please input Y : ");
            double Y = double.Parse(Console.ReadLine());

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origin");
            }
            else if (X == 0 && Y>=0)
            {
                Console.WriteLine("Y");
            }
            else if (X == 0 && Y <= 0)
            {
                Console.WriteLine("-Y");
            }
            else if (X >= 0 && Y == 0)
            {
                Console.WriteLine("X");
            }
            else if (X <= 0 && Y == 0)
            {
                Console.WriteLine("-X");
            }
            else if (X>=0 && Y >= 0)
            {
                Console.WriteLine("Quadrant 1");
            }
            else if (X <= 0 && Y >= 0)
            {
                Console.WriteLine("Quadrant 2");
            }
            else if (X <= 0 && Y <= 0)
            {
                Console.WriteLine("Quadrant 3");
            }
            else if (X >= 0 && Y <= 0)
            {
                Console.WriteLine("Quadrant 4");
            }
            Console.ReadLine();
        }
    }
}
