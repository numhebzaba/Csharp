using System;

namespace คูณร่วมน้อย
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double x = a, y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x += a;
                }
                else
                {
                    y += b;
                }
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
