using System;

namespace Week6_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            ////แบบทบทวนข้อ 1
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //string rotationOrder = Console.ReadLine();
            //double x=1,y=1,z = 1;

            //switch (rotationOrder)
            //{
            //    case "XYZ":
            //        //หมุนรอบแกน x
            //        y *= Math.Pow(-1, a );
            //        z *= Math.Pow(-1, a);
            //        //หมุนหรอบแน y
            //        x *= Math.Pow(-1, b);
            //        z *= Math.Pow(-1, b);
            //        //หมุนหรอบแน z
            //        x *= Math.Pow(-1, c);
            //        y *= Math.Pow(-1, c);
            //        Console.WriteLine("{0}{1}{2}",x,y,z);
            //        break;
            //    case "XZY":
            //        //หมุนรอบแกน x
            //        y *= Math.Pow(-1, a);
            //        z *= Math.Pow(-1, a);
            //        //หมุนหรอบแน z
            //        x *= Math.Pow(-1, b);
            //        y *= Math.Pow(-1, b);
            //        //หมุนหรอบแน y
            //        y *= Math.Pow(-1, c);
            //        z *= Math.Pow(-1, c);
            //        Console.WriteLine("{0}{1}{2}", x, y, z);
            //        break;
            //    case "YXZ":
            //        //หมุนรอบแกน y
            //        x *= Math.Pow(-1, a);
            //        z *= Math.Pow(-1, a);
            //        //หมุนหรอบแน x
            //        y *= Math.Pow(-1, b);
            //        z *= Math.Pow(-1, b);
            //        //หมุนหรอบแน z
            //        x *= Math.Pow(-1, c);
            //        y *= Math.Pow(-1, c);
            //        Console.WriteLine("{0}{1}{2}", x, y, z);
            //        break;
            //    case "YZX":
            //        //หมุนรอบแกน y
            //        x *= Math.Pow(-1, a);
            //        z *= Math.Pow(-1, a);
            //        //หมุนหรอบแน z
            //        x *= Math.Pow(-1, b);
            //        y *= Math.Pow(-1, b);
            //        //หมุนหรอบแน x
            //        y *= Math.Pow(-1, c);
            //        z *= Math.Pow(-1, c);
            //        Console.WriteLine("{0}{1}{2}", x, y, z);
            //        break;
            //    case "ZYX":
            //        //หมุนรอบแกน z
            //        x *= Math.Pow(-1, a);
            //        y *= Math.Pow(-1, a);
            //        //หมุนหรอบแน y
            //        x *= Math.Pow(-1, b);
            //        z *= Math.Pow(-1, b);
            //        //หมุนหรอบแน x
            //        y *= Math.Pow(-1, c);
            //        z *= Math.Pow(-1, c);
            //        Console.WriteLine("{0}{1}{2}", x, y, z);
            //        break;
            //    case "ZXY":
            //        //หมุนรอบแกน z
            //        x *= Math.Pow(-1, a);
            //        y *= Math.Pow(-1, a);
            //        //หมุนหรอบแน x
            //        y *= Math.Pow(-1, b);
            //        z *= Math.Pow(-1, b);
            //        //หมุนหรอบแน y
            //        x *= Math.Pow(-1, c);
            //        z *= Math.Pow(-1, c);
            //        Console.WriteLine("{0}{1}{2}", x, y, z);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid order");
            //        break;
            //}

            ////แบบทบทวนข้อ2
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Max(a, Math.Max(b, c)));

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //while(a!=0 && b != 0)
            //{
            //    if (a > b)
            //    {
            //        a = a - (a / b) * b;
            //    }
            //    else
            //    {
            //        b = b - (b / a) * a;
            //    }
            //}
            //if (a == 0)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();

            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());
            //int temp;
            //if (min > max)
            //{
            //    temp = min;
            //    min = max;
            //    max = temp;
            //}
            //int sum = 0;
            //for(int i = min; i <= max; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);


            //int n = int.Parse(Console.ReadLine());
            //int p = n - 1;
            //bool isPrime;
            //do
            //{
            //    p++;
            //    isPrime = true;
            //    for (int i = 2; i < p; i++)
            //    {
            //        if (p % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //} while (!isPrime);
            //Console.WriteLine(p);
            //Console.ReadLine();


            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (b == 1)
            //{
            //    for(int i = 1; i <= a; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    for (int i = a; i >= 1; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //////////////////////////////////////////////////////
            //double a = 0;
            //bool isValid = false;

            //while (isValid == false)
            //{
            //    a = double.Parse(Console.ReadLine());
            //    if (a <= 0)
            //    {
            //        Console.WriteLine("Error: Negative Number");
            //    }

            //    if (Math.Floor(a) !=a)
            //    {
            //        Console.WriteLine("Error : Decimal Number");
            //    }

            //    if (a >= 0 &&  Math.Floor(a)==a)
            //    {
            //        isValid = true;
            //    }
            //}
            //double sum = 0;
            //for(int i = 1;i <= (int)a; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            ////////////////////////////////////////////////////////////////

            //bool homeworkFinished = false;
            //bool goTobed = false;
            //bool awake = false;

            //bool homeworkError = false;
            //bool sleepError = false;

            //for (int i = 1; i <= 5; i++)
            //{
            //    string input = Console.ReadLine();
            //    if (input == "Do Homework")
            //    {
            //        homeworkFinished = true;
            //    }

            //    if (input == "Play Game")
            //    {
            //        if (homeworkFinished == false)
            //        {

            //            homeworkError = true;
            //        }
            //    }

            //    if (input == "Go to bed")
            //    {
            //        goTobed = true;
            //    }

            //    if (input == "awake")
            //    {
            //        awake = true;
            //    }
            //}
            //if ((goTobed == true && awake == true) || goTobed == false)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Wake up!");
            //    sleepError = true;
            //}
            //if (homeworkError)
            //{
            //    Console.WriteLine("Please do homework before playing game!");
            //}
            //if (homeworkError == false && sleepError == false)
            //{
            //    Console.WriteLine("Everything is fine");
            //}
            //////////////////////////////////////////////////////////////////
            ///


            //int n = 0;
            //bool isValid = false;

            //while (isValid == false)
            //{
            //    string input = Console.ReadLine();
            //    n = int.Parse(input);
            //    if (n % 2 == 0)
            //    {
            //        isValid = true;
            //        break;
            //    }
            //}

            //for (int row = 1; row <= n; row++)
            //{
            //    for(int column = 1; column <= n; column++)
            //    {
            //        //แถวเลขคี่
            //        if (row % 2 != 0)
            //        {
            //            if (column % 2 != 0)
            //            {
            //                Console.Write("O");
            //            }
            //            else
            //            {
            //                Console.Write("X");
            //            }
            //        }
            //        else
            //        {
            //            if (column % 2 != 0)
            //            {
            //                Console.Write("X");
            //            }
            //            else
            //            {
            //                Console.Write("O");
            //            }
            //        }
            //    }
            //    Console.WriteLine("");
            //}


            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //if (y < 3)
            //{
            //    do
            //    {
            //        Console.WriteLine("Please Re-Enter");
            //        x = int.Parse(Console.ReadLine());
            //        y = int.Parse(Console.ReadLine());
            //    } while (y < 3);
            //}

            //for(int i = 1; i <= x; i++)
            //{
            //    for(int j =1; j <= y; j++)
            //    {
            //        if (i == 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else if (i > 1 && i < x)
            //        {
            //            for(j = 1; j ==1; j++)
            //            {
            //                Console.Write("*");
            //            }
            //            for (j = 2; j < y; j++)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (j = y; j == y; j++)
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //        else if (i == x)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine("");

            //}
            //Console.ReadLine();
            //////////////////////////////////////////////////////////////////////////////////////////



            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a%2 != 0)
            //{
            //    do
            //    {
            //        Console.WriteLine("Please Re-Enter");
            //        a = int.Parse(Console.ReadLine());
            //        b = int.Parse(Console.ReadLine());
            //    } while (a % 2 != 0);
            //}


            //for (int row = 1; row <= a*b; row++)
            //{
            //    for (int column = 1; column <= a * b; column++)
            //    {
            //        if (((row-1) / b) % 2 == 0)
            //        {
            //            if(((column-1) / b) % 2 == 0)
            //            {
            //                Console.Write("O");
            //            }
            //            else
            //            {
            //                Console.Write("X");
            //            }
            //        }
            //        else
            //        {
            //            if (((column - 1) / b) % 2 == 0)
            //            {
            //                Console.Write("X");
            //            }
            //            else
            //            {
            //                Console.Write("O");
            //            }
            //        }
            //    }
            //    Console.WriteLine("");

            //}
            //////////////////////////////////////////////////////////////
            ///

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a % 2 != 0)
            {
                do
                {
                    Console.WriteLine("Please Re-Enter");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                } while (a % 2 != 0);
            }


            for (int row = 1; row <= a * b; row++)
            {
                for (int column = 1; column <= a * b; column++)
                {
                    if (((row - 1) / b) % 2 == 0)
                    {
                        if (((column - 1) / b) % 2 == 0)
                        {
                            if (row == 1 || column == 1)
                            {
                                Console.Write("O");
                            }
                            else if (row % b > 1 || column % a > 2)
                            {
                                Console.Write("N");
                            }
                            else if (row % b == 0 || column % a == 0)

                            {
                                Console.Write("O");
                            }
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                    else
                    {
                        if (((column - 1) / b) % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                }
                Console.WriteLine("");

            }

        }


    }
}
