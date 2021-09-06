using System;

namespace สามเหลี่ยมในตำนาน
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                int j = n - i;
                while (j > 0)
                {
                    Console.Write("*");
                    j -= 1;
                }
                Console.WriteLine("");
                i += 2;
            }
        }
    }
}
