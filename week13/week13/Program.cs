using System;

namespace week13
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double avg = 0;
            double[,] score = new double[4, 2]
            { { 3,8} ,{6,7 }, {8,10 } ,{9,7 } };
            for(int i = 0; i < score.GetLength(1); i++)
            {
                sum += score[3,i];
            }
            avg = sum / score.GetLength(1);
            Console.WriteLine(avg);
        }
    }
}
