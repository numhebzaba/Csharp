using System;

namespace Workshop_week8_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int remainder = a % b;
            //while (c >1) 
            //{
            //    remainder = (remainder * 10) % b;
            //    c--;
            //}
            //Console.WriteLine((remainder*10)/b);

            ///////////////////////////////////////////////////////////////////
            ///

            //string input = Console.ReadLine();

            //switch (input)
            //{

            //    case "A":
            //        Banana();
            //        Apple();
            //        Orange();
            //        Banana();
            //        Apple();
            //        Orange();
            //        Console.WriteLine("Banana Apple Orange Mango Banana Apple Orange");
            //        break;
            //    case "B":
            //        Console.WriteLine("Orange Orange Mango Banana Banana");
            //        break;
            //    case "C":
            //        Console.WriteLine("Mango Orange Orange Banana Apple Apple");
            //        break;
            //    default:
            //        break;
            //}
            //////////////////////////////////////////////////////////////////////////////

            //int inputNumber = int.Parse(Console.ReadLine());
            //string inputLetter =Console.ReadLine();

            //switch (inputLetter)
            //{
            //    case "A":

            //        break;
            //    case "C":

            //        break;
            //    case "T":

            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;

            //}
            //////////////////////////////////////////////////////////

            //int inputNumber = int.Parse(Console.ReadLine());
            //string inputLetter = Console.ReadLine();

            //switch (inputLetter)
            //{
            //    case "A":
            //        ShowLine(inputNumber, inputLetter);
            //        break;
            //    case "B":
            //        ShowLine(inputNumber, inputLetter);
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}
            /////////////////////////////////////////

            //int input = int.Parse(Console.ReadLine());
            //if(input< 10)
            //{
            //    table1(input);
            //}else if(input>=10&&input <100)
            //{
            //    int a = input % 10;
            //    int b = input / 10;
            //    table2(a, b);
            //}else if (input >= 100)
            //{
            //    int a = input % 10;
            //    int b = (input / 10)%10;
            //    int c = input / 100;
            //    table3(a, b, c);
            //}

            ///////////////////////////////////////////////////////

            //int treeleight = int.Parse(Console.ReadLine());
            //double node1, node2;
            //double rootNode = 0;
            //for(int i =0; i< treeleight; i++)
            //{
            //    node1 = double.Parse(Console.ReadLine());
            //    node2 = double.Parse(Console.ReadLine());
            //    if(i % 2 == 0)
            //    {
            //        rootNode = Min3(node1, node2, rootNode);
            //    }
            //    else
            //    {
            //        rootNode = Max3(node1, node2, rootNode);
            //    }
            //}
            //Console.WriteLine(rootNode);
            ///////////////////////////////////////////////////////////////////////
            ///

            int num = int.Parse(Console.ReadLine());
            int result = num;
            while (num > 0)
            {
                result = GCD(result, num);
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }

        static void Banana()
        {
            Console.Write(" Banana ");
        }
        static void Orange()
        {
            Console.Write(" Orange ");
        }
        static void Mango()
        {
            Console.Write(" Mango ");
        }
        static void Apple()
        {
            Console.Write(" Apple ");
        }
        static void areaSquare(int length)
        {
            Console.WriteLine(length*length);
        }
        static void areaCircle(double r)
        {
            Console.WriteLine(Math.PI*r*r);
        }
        static void areaTri(int length)
        {
            Console.WriteLine((Math.Sqrt(3)/4)*length*length);
        }
        static void Row(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write("*");
        }
        static void Column(int n)
        {
            for(int i = 1; i <= n; i++)
                Console.WriteLine("*");
        }
        static void ShowLine(int lenght, string type)
        {
            for (int i = 1; i <= lenght; i++)
            {
                if (type == "A")
                    Console.Write("*");
                else if (type == "B")
                    Console.WriteLine("*");
            }
        }
        static void table1(int length)
        {
            for(int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    Console.Write("A");
                }
                Console.WriteLine("");
            }
        }
        static void table2(int lenght,int width)
        {
            for(int i =1; i <= lenght; i++)
            {
                for(int j = 1; j <= width; j++)
                {
                    Console.Write("B");
                }
                Console.WriteLine("");
            }
        }
        static void table3(int lenght,int width,int cha)
        {
            for (int i = 1; i <= lenght; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write(cha);
                }
                Console.WriteLine("");
            }
        }
        static double Min3 (double a, double b, double c)
        {
            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else
                return c;
        }
        static double Max3(double a, double b, double c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
        static int GCD (int a, int b)
        {
            while(a !=0 && b != 0)
            {
                if (a > b)
                {
                    a -= (a / b) * b;
                }
                else
                {
                    b -= (b / a) * a;
                }
                
            }
            if (a == 0)
                return b;
            else
                return a;
        }
    }
}
