using System;

namespace Workshop_Coding_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //string Op = Console.ReadLine();

            //switch(Op)
            //{
            //    case "+":
            //        Console.WriteLine(x  + Op + y + "=" + (x + y));
            //        break;
            //    case "-":
            //        Console.WriteLine(x  + Op + y + "=" + (x - y));
            //        break;
            //    case "*":
            //        Console.WriteLine(x  + Op + y + "=" + (x * y));
            //        break;
            //    case "/":
            //        Console.WriteLine(x  + Op + y + "=" + (x / y));
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operator");
            //        break;
            //}
            //Console.ReadLine();

            //bool p = bool.Parse(Console.ReadLine());
            //bool q = bool.Parse(Console.ReadLine());
            //string Lg = Console.ReadLine();

            //switch (Lg)
            //{
            //    case "AND" :
            //        Console.WriteLine(p && q);
            //        break;
            //    case "OR":
            //        Console.WriteLine(p || q);
            //        break;
            //    case "NAND":
            //        Console.WriteLine(!(p && q));
            //        break;
            //    case "XOR":
            //        Console.WriteLine(!(p == q));
            //        break;
            //    case "XNOR":
            //        Console.WriteLine(p == q);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid gate");
            //        break;
            //}
            //Console.ReadLine();


            //string day = Console.ReadLine();
            //Console.Write("Color of the day :");
            //if(day == "Monday")
            //{
            //    Console.Write(" Yellow");
            //}
            //else if (day == "Tuesday")
            //{
            //    Console.Write(" Pink");
            //}
            //else if (day == "Wednesday")
            //{
            //    Console.Write(" Green");
            //}
            //else if (day == "Thursday")
            //{
            //    Console.Write(" Orange");
            //}
            //else if (day == "Friday")
            //{
            //    Console.Write(" Blue");
            //}
            //else if (day == "Saturday")
            //{
            //    Console.Write(" Purple");
            //}
            //else if (day == "Sunday")
            //{
            //    Console.Write(" Red");
            //}
            //else
            //{
            //    Console.Write(" Error");
            //}
            //Console.ReadLine();


            //string day = Console.ReadLine();
            //Console.Write("Color of the day :");
            //switch (day)
            //{
            //    case "Monday":
            //        Console.Write(" Yellow");
            //        break;
            //    case "Tuesday":
            //        Console.Write(" Pink");
            //        break;
            //    case "Wednesday":
            //        Console.Write(" Green");
            //        break;
            //    case "Thursday":
            //        Console.Write(" Orange");
            //        break;
            //    case "Friday":
            //        Console.Write(" Blue");
            //        break;
            //    case "Saturday":
            //        Console.Write(" Purple");
            //        break;
            //    case "Sunday":
            //        Console.Write(" Red");
            //        break;
            //    default:
            //        Console.Write("Error");
            //        break;
            //}
            //Console.ReadLine();




            //string day = Console.ReadLine();

            //if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            //{
            //    Console.Write("Work day");
            //}
            //else if (day == "Saturday" || day == "Sunday")
            //{
            //    Console.Write("Weeken");
            //}
            //else
            //{
            //    Console.Write("Error");
            //}
            //Console.ReadLine();


            //string day = Console.ReadLine();

            //switch (day)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Wednesday":
            //    case "Thursday":
            //    case "Friday":
            //        Console.Write("Work day");
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        Console.Write("Weeken");
            //        break;
            //    default:
            //        Console.Write("Error");
            //        break;
            //}
            //Console.ReadLine();



            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());

            //if((x< y+z) || (y < x + z) || (z < x + y))
            //{
            //    if ((x == z)&&( x == y))
            //    {
            //        Console.WriteLine("Equilateral triangle");
            //    }else if((x != z) && (x != y) && (z != y))
            //    {
            //        Console.WriteLine("Scalene triangle");
            //    }else if (x==y || x==z || y==z)
            //    {
            //        Console.WriteLine("Isosceles triangle");
            //    }
            //}
            //else
            //{

            //}Console.ReadLine();


            //double unit = double.Parse(Console.ReadLine());

            //if (unit<=50)
            //{
            //    Console.WriteLine(unit*5);
            //}
            //else if (unit <= 150)
            //{
            //    Console.WriteLine(((50)*5+(unit-50)*7.5)*1.2);
            //}
            //else if (unit < 250)
            //{
            //    Console.WriteLine((((50) * 5) + (100 * 7.5)+((unit-150)*10))*1.2);
            //}
            //else
            //{
            //    Console.WriteLine((unit * 15)*1.2);
            //}
            //Console.ReadLine();



            //double A = double.Parse(Console.ReadLine());
            //double B = double.Parse(Console.ReadLine());
            //double C = double.Parse(Console.ReadLine());



            //if (A<=5000 && B <=5000 && C <= 5000 && A!=B && A !=B && B !=C&&A>=0&&B>=0&&C>=0)
            //{
            //    string X = Console.ReadLine();
            //    string Y = Console.ReadLine();
            //    string Z = Console.ReadLine();
            //    double distance = 0;
            //    double Displacement = 0;
            //    if (X == "A")
            //    {
            //        if( Y == "B")
            //        {
            //             distance = Math.Abs(B-A)+Math.Abs(C-B);
            //             Displacement = Math.Abs(C-A);
            //        }
            //        else if (Y == "C")
            //        {
            //             distance = Math.Abs(C - A) + Math.Abs(B - C);
            //             Displacement = Math.Abs(B - A);
            //        }
            //    }
            //    else if (X == "B")
            //    {
            //        if (Y == "A")
            //        {
            //             distance = Math.Abs(A - B) + Math.Abs(C - A);
            //             Displacement = Math.Abs(C - B);
            //        }
            //        else if (Y == "C")
            //        {
            //             distance = Math.Abs(C - B) + Math.Abs(A - C);
            //             Displacement = Math.Abs(A - B);
            //        }
            //    }
            //    else if (X == "C")
            //    {
            //        if (Y == "A")
            //        {
            //             distance = Math.Abs(A - C) + Math.Abs(B - A);
            //             Displacement = Math.Abs(B - C);
            //        }
            //        else if (Y == "B")
            //        {
            //             distance = Math.Abs(B - C) + Math.Abs(A - B);
            //             Displacement = Math.Abs(A - C);
            //        }
            //    }
            //    Console.WriteLine(distance);
            //    Console.WriteLine(Displacement);
            //}
            //else if (A >= 5000 || B >=5000 ||C >=5000)
            //{
            //    Console.WriteLine("too much distance.");
            //}
            //else if (A<=0||B<=0||C<=0)
            //{
            //    Console.WriteLine("You input Negative number.");
            //}
            //else 
            //{
            //    Console.WriteLine("Please input positive integer number.");
            //}
            //Console.ReadLine();

            bool isAValid = false;
            bool isBValid = false;
            bool isCValid = false;

            string inputA = Console.ReadLine();
            double positionA = 0;
            bool isAInteger = double.TryParse(inputA, out positionA);
            if (isAInteger = true)
            {
                if(positionA>=0 && positionA <= 5000)
                {
                     isAValid = true;
                }
                else
                {
                    Console.WriteLine("A is not within 0-5000");
                }
            }
            else
            {
                Console.WriteLine("A is not an integer number");
            }


            string inputB = Console.ReadLine();
            double positionB = 0;
            bool isBInteger = double.TryParse(inputB, out positionB);
            if (isBInteger = true)
            {
                if (positionB >= 0 && positionB <= 5000)
                {
                    if (inputA!=inputB) 
                    {
                        isBValid = true;
                    }
                    else
                    {
                        Console.WriteLine("B is same A");
                    }
                }
                else
                {
                    Console.WriteLine("B is not within 0-5000");
                }
            }
            else
            {
                Console.WriteLine("B is not an integer number");
            }

            string inputC = Console.ReadLine();
            double positionC = 0;
            bool isCInteger = double.TryParse(inputC, out positionC);
            if (isCInteger = true)
            {
                if (positionC >= 0 && positionC <= 5000)
                {
                    if (inputC !=inputA && inputC != inputB)
                    {
                        isCValid = true;
                    }
                    else if (inputC==inputA)
                    {
                        Console.WriteLine("C is same A");
                    }
                    else if (inputC == inputB)
                    {
                        Console.WriteLine("C is same B");
                    }
                }
                else
                {
                    Console.WriteLine("C is not within 0-5000");
                }
            }
            else
            {
                Console.WriteLine("C is not an integer number");
            }


            if (isAValid && isBValid && isCValid)
            {
                string inputDestination1 = Console.ReadLine();
                string inputDestination2 = Console.ReadLine();
                string inputDestination3 = Console.ReadLine();

                double destinationPostion1 =0;
                double destinationPostion2 =0;
                double destinationPostion3 =0;

                switch (inputDestination1)
                {
                    case "A":
                        destinationPostion1 = positionA;
                        break;
                    case "B":
                        destinationPostion1 = positionB;
                        break;
                    case "C":
                        destinationPostion1 = positionC;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                switch (inputDestination2)
                {
                    case "A":
                        destinationPostion2 = positionA;
                        break;
                    case "B":
                        destinationPostion2 = positionB;
                        break;
                    case "C":
                        destinationPostion2 = positionC;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                switch (inputDestination3)
                {
                    case "A":
                        destinationPostion3 = positionA;
                        break;
                    case "B":
                        destinationPostion3 = positionB;
                        break;
                    case "C":
                        destinationPostion3 = positionC;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                double distance1 = Math.Abs(destinationPostion2 - destinationPostion1);
                double distance2 = Math.Abs(destinationPostion3 - destinationPostion2);
                double totalDistance = distance1 + distance2;

                double displacement = Math.Abs(destinationPostion3 - destinationPostion1);
                //Console.WriteLine(destinationPostion1);
                //Console.WriteLine(destinationPostion2);
                //Console.WriteLine(destinationPostion3); 
                //Console.WriteLine(distance1);
                //Console.WriteLine(distance2);
                Console.WriteLine(totalDistance);
                Console.WriteLine(displacement);
                Console.Read();
            }
        }
    }
}
