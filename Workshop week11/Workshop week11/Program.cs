using System;

namespace Workshop_week11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] destinationNodeArray = new int [10];
            //for(int i =0;i < 10; i++)
            //{
            //    destinationNodeArray[i] = int.Parse(Console.ReadLine());
            //}
            //int currentNodeIndex = int.Parse(Console.ReadLine());
            //int traverseCount = int.Parse(Console.ReadLine());

            //while (traverseCount > 0)
            //{
            //    currentNodeIndex = destinationNodeArray[currentNodeIndex];
            //    traverseCount--;     
            //}
            //Console.WriteLine(currentNodeIndex);

            ////////////////////////////////////////////////////////
            ///

            //DDA
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //string [,] table = new string[width,height];
            //for(int a = 0; a < width; a++)
            //{
            //    for(int b = 0; b < height; b++)
            //    {
            //        table[a,b] = " ";
            //    }
            //}

            //float x, y, dx, dy, step;
            //float x1 = float.Parse(Console.ReadLine());
            //float y1 = float.Parse(Console.ReadLine());
            //float x2 = float.Parse(Console.ReadLine());
            //float y2 = float.Parse(Console.ReadLine());

            //dx = x2 - x1;
            //dy = y2 - y1;

            //if (Math.Abs(dx) >= Math.Abs(dy))
            //{
            //    step = Math.Abs(dx);
            //}
            //else
            //{
            //    step = Math.Abs(dy);
            //}

            //dx /= step;
            //dy /= step;
            //x = x1;
            //y = y1;

            //for(int l = 0; l<=step;l++)
            //{

            //    table[(int)Math.Round(x), (int)Math.Round(y)] = "#";

            //    x += dx;
            //    y += dy;
            //}
            //for(int a = 0; a < width; a++)
            //{
            //    for(int b = 0; b < height; b++)
            //    {
            //        Console.Write(table[a, b]);
            //    }
            //    Console.WriteLine();

            ////////////////////////////////////////////////////////////////
            ///

            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //char[,] image = new char[width, height];
            //for(int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++) 
            //    {
            //        image[j, i] = char.Parse(Console.ReadLine());
            //    } 
            //}

            //for(int i = 0; i < width; i++)
            //{
            //    for (int j = 0; j< height; j++)
            //    {
            //        Console.Write(image[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            ////////////////////////////////////////////////////////

            //int N = int.Parse(Console.ReadLine());
            //string[] ArrayofN = new string[N];
            //for(int i = 0; i< N; i++)
            //{
            //    ArrayofN[i] = "X";
            //}

            //while (true)
            //{
            //    int A = int.Parse(Console.ReadLine());
            //    if (A == -1)
            //        break;
            //    string C = Console.ReadLine();
            //    if (C == "-1")
            //        break;
            //    ArrayofN[A - 1] = C;
            //    for (int i = 0; i < N; i++)
            //    {
            //        Console.Write(ArrayofN[i]);
            //    }
            //}

            ////////////////////////////////////////////////////////


            //int[] collection = new int[0];
            //bool isEnded = false;
            //while (isEnded == false)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    for(int i = 0; i < collection.Length; i++)
            //    {
            //        if (collection[i] == input)
            //        {
            //            Console.WriteLine("Duplicated Number!");
            //            isEnded = true;
            //        }
            //    }

            //    int[] newCollection = new int[collection.Length + 1];
            //    for(int i = 0; i < collection.Length; i++)
            //    {
            //        newCollection[i] = collection[i];
            //    }
            //    newCollection[newCollection.Length - 1] = input;

            //    collection = newCollection;
            //}

            //////////////////////////////////////////////////////

            //int Row = int.Parse(Console.ReadLine());
            //int Colunm = int.Parse(Console.ReadLine());

            //string[,] table = new string[Row, Colunm];
            //for(int i =0; i< Row; i++)
            //{
            //    for (int j = 0; j < Colunm; j++)
            //    {
            //        table[i, j] = "0";
            //        Console.Write(table[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int RowSeat = int.Parse(Console.ReadLine());
            //int ColunmSeat = int.Parse(Console.ReadLine());
            //table[RowSeat-1, ColunmSeat-1] = "X";

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Colunm; j++)
            //    {
            //        Console.Write(table[j,i]) ;
            //    }
            //    Console.WriteLine();
            //}

            ////////////////////////////////////////

            string message = Console.ReadLine();

            int numberCount = 0;
            int upperCaseCount = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char character = message[i];
                string value = character.ToString();
                int foundNumber = 0;
                if (int.TryParse(value,out foundNumber))
                {
                    numberCount++;
                }else if (value == value.ToUpper())
                {
                    upperCaseCount++;
                }
            }

            Console.WriteLine("Number : {0}",numberCount);
            Console.WriteLine("Number : {0}",upperCaseCount);
        }

    }
}
