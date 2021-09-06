using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a, b, c;
            //c = double.Parse(Console.ReadLine());
            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            //double area = 0.5 * c * (a + b);
            //Console.WriteLine(area);
            double sector = double.Parse(Console.ReadLine());
            double radius = double.Parse(Console.ReadLine());
            double area = sector / 2 * Math.Pow(radius, 2);
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
