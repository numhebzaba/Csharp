using System;

namespace FinalCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[3, 3];
            int zero_i = 0;
            int zero_j = 0;

            for (int i = 0; i <= table.GetLength(0); i++)
            {
                for (int j = 0; i <= table.GetLength(1); j++)
                {
                    table[i, j] = int.Parse(Console.ReadLine()); //ผู้ใช้กรอกข้อมูลถูกต้อง
                    if (table[i, j] == 0)
                    {
                        zero_i = i;
                        zero_j = j;
                    }
                }
            }

            table[zero_i, zero_j] = int.Parse(Console.ReadLine());
            if(   table[zero_i, zero_j] == table[zero_i + 1, zero_j]
               || table[zero_i, zero_j] == table[zero_i + 2, zero_j]
               || table[zero_i, zero_j] == table[zero_i - 1, zero_j]
               || table[zero_i, zero_j] == table[zero_i - 2, zero_j]
               || table[zero_i, zero_j] == table[zero_i, zero_j + 1]
               || table[zero_i, zero_j] == table[zero_i, zero_j + 2]
               || table[zero_i, zero_j] == table[zero_i, zero_j - 1]
               || table[zero_i, zero_j] == table[zero_i, zero_j - 2]
               )
            {
                Console.WriteLine("The number is available");
            }
            else
            {
                for (int i = 0; i <= table.GetLength(0); i++)
                {
                    for (int j = 0; i <= table.GetLength(1); j++)
                    {
                        Console.Write(table[i,j]);
                    }
                    Console.WriteLine("");
                }
            }

        }
    }
}
