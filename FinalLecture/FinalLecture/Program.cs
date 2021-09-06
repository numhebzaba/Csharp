using System;

namespace FinalLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input Points ");
            //double point = double.Parse(Console.ReadLine());

            //if(point < 50)
            //{
            //    Console.WriteLine("Grade F");
            //}
            //else if (point>=50 && point<60)
            //{
            //    Console.WriteLine("Grade D");
            //}
            //else if (point >= 60 && point < 70)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else if (point >= 70 && point < 80)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (point >= 80 )
            //{
            //    Console.WriteLine("Grade F");
            //}

            //int x = 8;
            //int y = 5;
            //SquareThem(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int a, b, c;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = M1(b, a);
            //Console.WriteLine(c);

            //PrintLine();
            //PrintLine();
            //int  = 0;

            //Console.Write("Input Divided : ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Input Divisor : ");
            //double y = double.Parse(Console.ReadLine());
            //double z = Math.Floor(x / y);
            //double a = x % y;

            //Console.WriteLine("Quotient of {0}/{1} is {2} and remainder is {3}",x,y,z,a);

            char[,] x = new char[4,2];
            x[0, 0] = 'v';
            x[0, 1] = 'a';
            x[1, 0] = 'y';
            x[1, 1] = 'q';
            x[2, 0] = 'p';
            x[2, 1] = 'z';
            x[3, 0] = 's';
            x[3, 1] = 'b';
            Math.lo
        }
        static void SquareThem(ref int x,ref int y)
        {
            x = (int)Math.Pow(x, 2);
            y = (int)Math.Pow(y, 2);
        }
        static int M1(int a, int b)
        {
            a++;
            b++;
            return a * b;
        }
        static void PrintLine()
        {
            for(int  i =0;i<20;i++)
                Console.Write('*');
            Console.WriteLine();
        }
        
    }
}
