using System;

namespace Workshop_Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int numDigit = 0;
            //string message = "";
            //while (n > 0)
            //{
            //    message += n % 10;
            //    n /= 10;
            //    numDigit++;
            //}
            //numDigit = 8 - numDigit;
            //while (numDigit > 0)
            //{
            //    message = "0" + message;
            //    numDigit--;
            //}
            //Console.Write(message);
            ///////////////////////////////////////////////////////////////////////////
            ///

            //int sum = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= 6; i++)
            //{
            //    for(int j =1; j <=6; j++)
            //    {
            //        for(int k =1; k <= 6; k++)
            //        {
            //            if (i + j + k == sum)
            //            {
            //                Console.WriteLine("{0},{1},{2}",i,j,k);
            //            }
            //        }
            //    }
            //}
            /////////////////////////////////////////////////////////////////////////
            ///

            //int size = int.Parse(Console.ReadLine());
            //int qRow = int.Parse(Console.ReadLine());
            //int qCol = int.Parse(Console.ReadLine());
            //for(int i = 0;i < size; i++)
            //{
            //    for( int j = 0; j < size; j++)
            //    {
            //        if(i==qRow
            //            || j ==qCol
            //            ||i+j==qRow+qCol
            //            || i - j == qRow - qCol)
            //        {
            //            Console.WriteLine("{0},{1}",i,j);
            //        }

            //    }
            //}
            //////////////////////////////////////////////////

            //int frequency1 = 0;
            //int frequency2 = 0;
            //int frequency3 = 0;
            //// ...frequency7

            //float input = float.Parse(Console.ReadLine());
            //while (input > 0 && input < 49)
            //{
            //    if (input >= 0 && input < 7)
            //    {
            //        frequency1++;
            //    }else if(input >= 7 && input < 14)
            //    {
            //        frequency2++;
            //    }
            //    else if (input >= 14 && input < 21)
            //    {
            //        frequency3++;
            //    }
            //    ///else7
            //    else
            //    {
            //        break;
            //    }
            //    input = float.Parse(Console.ReadLine());
            //}
            //int numberOfModal = 0;
            //if (frequency1 > frequency2)
            //{
            //    numberOfModal++;
            //}
            //if (frequency2 > frequency1 && frequency2 > frequency3)
            //{
            //    numberOfModal++;
            //}
            //if (frequency3 > frequency2)
            //{
            //    numberOfModal++;
            //}

            //if (numberOfModal == 0)
            //{
            //    Console.WriteLine("No modal");
            //}else if (numberOfModal == 1)
            //{
            //    Console.WriteLine("Single-modal");
            //}else if (numberOfModal > 1)
            //{
            //    Console.WriteLine("Multi-modal");
            //}

            //////////////////////////////////////////////////////

            //int Notebook = 20;
            //int Phone = 20;
            //int Tablet = 20;

            //Console.WriteLine("Notebook = {0}, Phone = {1}, Tablet = {2}",Notebook,Phone,Tablet);

            //bool isEnded = false;
            //while (isEnded == false)
            //{
            //    string input = Console.ReadLine();
            //    switch (input)
            //    {
            //        case "Notebook":
            //            Notebook--;
            //            Console.WriteLine("Notebook = {0}, Phone = {1}, Tablet = {2}", Notebook, Phone, Tablet);
            //            break;
            //        case "Phone":
            //            Phone--;
            //            Console.WriteLine("Notebook = {0}, Phone = {1}, Tablet = {2}", Notebook, Phone, Tablet);
            //            break;
            //        case "Tablet":
            //            Tablet--;
            //            Console.WriteLine("Notebook = {0}, Phone = {1}, Tablet = {2}", Notebook, Phone, Tablet);
            //            break;
            //        default:
            //            isEnded = true;
            //            break;

            //    }
            //}
            //Console.WriteLine("End");
            ///////////////////////////////////////////////////////////////////////////

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

            //for (int i = 1; i <= x; i++)
            //{
            //    for (int j = 1; j <= y; j++)
            //    {
            //        if (i == 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else if (i > 1 && i < x)
            //        {
            //            for (j = 1; j == 1; j++)
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

            ///////////////////////////////////////////////////////////////////////////////////

            //int x = 0;

            //if (x < 5)
            //{
            //    do
            //    {
            //        x = int.Parse(Console.ReadLine());
            //        if(x < 5 || x % 2 == 0)
            //        Console.WriteLine("Please Re-Enter");

            //    } while (x < 5 || x % 2 == 0);

            //    for (int i = 1; i <= x; i++)
            //    {
            //        for (int j = 1; j <= x; j++)
            //        {
            //            if (i == j || i + j == x + 1)
            //            {
            //                Console.Write("X");
            //            }
            //            else
            //            {
            //                Console.Write("O");
            //            }
            //        }
            //        Console.WriteLine("");

            //    }
            //    Console.ReadLine();
            //}
            ///////////////////////////////////////////////////////////////////


            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a % 2 != 0)
            //{
            //    do
            //    {
            //        Console.WriteLine("Please Re-Enter");
            //        a = int.Parse(Console.ReadLine());
            //        b = int.Parse(Console.ReadLine());
            //    } while (a % 2 != 0);
            //}


            //for (int row = 1; row <= a * b; row++)
            //{
            //    for (int column = 1; column <= a * b; column++)
            //    {
            //        if (((row - 1) / b) % 2 == 0)
            //        {
            //            if (((column - 1) / b) % 2 == 0)
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

            //วิธีที่2
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for(int row = 1; row <= n * s; row++)
            {
                for (int column = 1; column <= n * s; column++)
                {
                    //คอลัมคู่
                    if (Math.Ceiling(column/(double)s)%2==0)
                    {
                        //แถวคู่
                        if(Math.Ceiling(row / (double)s) % 2 == 0)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                    else
                    {
                        if (Math.Ceiling(row / (double)s) % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
