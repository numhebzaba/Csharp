using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input Divided : ");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.Write("Input Divisor : ");
            //int input2 = int.Parse(Console.ReadLine());
            //Console.Write("Quotient of {0}/{1} is "+input1/input2+" and remainder is "+ input1%input2+".",input1,input2);


            //Console.Write("Input a temperature in degree Celsius : ");
            //double X = double.Parse(Console.ReadLine());
            //double Y = (9.0/5)*X+32 ;
            //Console.WriteLine("{0}"+ " degrees Celsius is equivalent to "+"{1}"+" degrees Fahrenheit",X,Y);


            //Console.Write("Please input a : ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Please input b : ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Please input c : ");
            //double c = double.Parse(Console.ReadLine());

            //double num1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 *a * c))) / (2 * a);
            //double num2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 *a * c))) / (2 *a);
            //Console.Write("The answers of equation is "+"{0:F}"+ " and "+"{1:F}",num1,num2);


            Console.Write("Please input X : ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Please input Y : ");
            double Y = double.Parse(Console.ReadLine());
            double Z = Math.Sqrt(Math.Pow(Y,2)+Math.Pow(X,2));
            Console.WriteLine("The length of Z is "+"{0:f4}",Z);
            Console.WriteLine("The length of perimeter is "+(X+Y+Z));

        }
    }
}
