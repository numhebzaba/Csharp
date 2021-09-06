using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //float sector = float.Parse(Console.ReadLine());
            //float radius = float.Parse(Console.ReadLine());
            //float area = sector / 2 * Math.Pow(radius,2);
            //Console.WriteLine(area);
            //Console.ReadLine();

            float a, b, c;
            c = float.Parse(Console.ReadLine());
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            float area = (0.5)* c * (a + b);
            Console.WriteLine(area);
            Console.ReadLine();

        }
    }
}
