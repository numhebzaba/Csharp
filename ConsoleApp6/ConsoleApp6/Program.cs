using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please input your height : ");
            //double x = double.Parse(Console.ReadLine());
            //if(x<=120)
            //{
            //    Console.WriteLine("Your ticket price is 250 baht.");
            //}else
            //{
            //    Console.WriteLine("Your ticket price is 350 baht.");
            //}
            //Console.ReadLine();

            Console.Write("Please input your item's price : ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Are you may member? : ");
            string member = Console.ReadLine();

            if(member=="Y")
            {
                double dis = price * 0.1;
                Console.WriteLine("Your discount is " + dis + " bath.");
                Console.WriteLine("Your price is "+ (price-dis) +" baht. Thank you");
            }else
            {
                Console.WriteLine("Your price is " + (price) + " baht. Thank you");
            }
            Console.ReadLine();
        }
    }
}
