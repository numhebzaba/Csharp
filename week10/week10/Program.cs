using System;

namespace week10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            a = -19;
            b = 5;
            c = 5;
            d = 12;

            Cal(a,b,c,d,out e,out f);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
        static void CalDistanceAndSlope(double x1,double y1,double x2,double y2,out double disTance,out double Slope)
        {
            disTance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Slope = ((y2 - y1) / (x2 - x1));
        }
    }
}
