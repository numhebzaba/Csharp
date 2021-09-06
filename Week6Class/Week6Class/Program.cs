using System;

namespace Week6Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = Console.ReadLine();

            //if (x == "A")
            //{
            //    Console.WriteLine("Your point is 4.0");
            //}
            //else if (x == "B")
            //{
            //    Console.WriteLine("Your point is 3.0");
            //}
            //else if (x == "C")
            //{
            //    Console.WriteLine("Your point is 2.0");
            //}
            //else if (x == "D")
            //{
            //    Console.WriteLine("Your point is 1.0");
            //}
            //else if (x == "F")
            //{
            //    Console.WriteLine("Your point is 0.0");
            //}
            //Console.ReadLine();


            //string x = Console.ReadLine();
            //switch (x)
            //{
            //    case "A":
            //        Console.WriteLine("Your point is 4.0");
            //        break;
            //    case "B":
            //        Console.WriteLine("Your point is 3.0");
            //        break;
            //    case "C":
            //        Console.WriteLine("Your point is 2.0");
            //        break;
            //    case "D":
            //        Console.WriteLine("Your point is 1.0");
            //        break;
            //    case "F":
            //        Console.WriteLine("Your point is 0.0");
            //        break;
            //        Console.ReadLine();
            //}

            //int n = int.Parse(Console.ReadLine());
            //int x = 1;
            //int sum = 0;
            //while (x <= n)
            //{
            //    sum = sum + x;
            //    x++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int x = 0;
            do
            {
                sum = sum + x;
                x--;
            } while (x>=n);
            Console.WriteLine(sum);
        }
    }
}
