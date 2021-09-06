using System;

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = 0, SUM = 0, i = 0;
            //Console.WriteLine("Please input number : ");
            //N = int.Parse(Console.ReadLine());

            //for (i = 0; i <= N; i++)
            //    SUM = SUM +(i*i);
            //Console.WriteLine("SUM = {0}",SUM);


            //int i, j, n;
            //Console.Write("Input n : ");
            //n = int.Parse(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    for (j = 1; j <= n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int i, j,l, n;
            Console.Write("Input n : ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {

                for (l = i; l <= n-1; l++)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= (2*i-1) ; j++)
                {
                    Console.Write("*");
                }
                for (l = i; l <= n - 1; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

        }

    }
}
