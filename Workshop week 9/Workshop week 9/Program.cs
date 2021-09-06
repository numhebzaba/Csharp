using System;

namespace Workshop_week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //float x = 0, y = 0;
            //do
            //{
            //    x += float.Parse(Console.ReadLine());
            //    y += float.Parse(Console.ReadLine());
            //    Console.WriteLine("({0},{1})",x,y);
            //} while (!isOutofRange(x, y, 10));

            /////////////////////////////////////////////////////////
            ///

            //float uX = float.Parse(Console.ReadLine());
            //float uY = float.Parse(Console.ReadLine());
            //float uZ = float.Parse(Console.ReadLine());
            //float vX = float.Parse(Console.ReadLine());
            //float vY = float.Parse(Console.ReadLine());
            //float vZ = float.Parse(Console.ReadLine());

            //cross(ref uX, ref uY, ref uZ, vX, vY, vZ);

            //Console.WriteLine("{0},{1},{2}",uX,uY,uZ);
            ///////////////////////////////////////////////////////////////////

            //// P'Pun
            // exercis 1 


            //int n = int.Parse(Console.ReadLine());
            //countDown(n);

            ////////////////////
            ///exercis 2 
            ///

            //int width = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //if (width < 2 || length < 2)
            //{
            //    while (width < 2 || length < 2)
            //    {
            //        width = int.Parse(Console.ReadLine());
            //        length = int.Parse(Console.ReadLine());
            //    }
            //}
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //chaseTable(width, length, a, b);
            ///////////////////////////////////////////////////
            ///exercise 3
            ///

            Console.WriteLine("Please choose your password : ");
            string passWord = Console.ReadLine();
            Enterpass(passWord);
        }
        static bool isOutofRange(float x,float y,float d)
        {
            return Math.Abs(x) + Math.Abs(y) > d;
        }
        static void cross(ref float a,ref float b,ref float c,float d,float e,float f)
        {
            float resultI, resultJ,resultK;
            resultI = b * f - c * e;
            resultJ = c * d - a * f;
            resultK = a * e - b * d;
            a = resultI;
            b = resultJ;
            c = resultK;
        }
        static void countDown(int n)
        {
            Console.WriteLine(n);
            n--;
            if(n>0)
                 countDown(n);
            
        }
        static void chaseTable(int a, int b, string c,string d)
        {
            for (int i = 1; i <= a; i++)
            {
                for(int j = 1; j <= b; j++)
                {
                    if (i%2 != 0)
                    {
                        if(j%2 != 0)
                        {
                            Console.Write(c);
                        }
                        else
                        {
                            Console.Write(d);
                        }
                    }
                    else
                    {
                        if (j% 2 != 0)
                        {
                            Console.Write(d);
                        }
                        else
                        {
                            Console.Write(c);
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
        static void Enterpass(string pass)
        {
            Console.WriteLine("Please enter your password : ");
            string enterPassword = Console.ReadLine();
            if (enterPassword == pass)
            {
                Acttype(pass);
            }
            else
            {
                Console.WriteLine("Wrong Password");
                Enterpass(pass);
            }
        }
        static void Acttype(string passWord)
        {
            Console.WriteLine("Please choose your action : ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                return ;
            }else if (x == 1)
            {
                while (true)
                {
                    Console.WriteLine("Please enter your new password : ");
                    string newPass = Console.ReadLine();
                    if (newPass == passWord)
                    {
                        Console.WriteLine("Sorry please choose a different password ");
                    }else if(newPass != passWord)
                    {
                        Console.WriteLine("Please confirm your new password :");
                        string ConNewpass = Console.ReadLine();
                        if (ConNewpass == newPass)
                        {
                            passWord = ConNewpass;
                            Enterpass(passWord);
                        }
                        else
                        {
                            Console.WriteLine("Sorry your confirmed password doesn’t match your new password");
                            Enterpass(passWord);
                        }
                    }
                }
            }
        }
    }
}
