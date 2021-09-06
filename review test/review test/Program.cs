using System;

namespace review_test
{
    class UnitConverter {
        int ratio;

        public UnitConverter(int unitRatio){
            ratio = unitRatio;
        }

        public int Convert(int unit) {
            return unit * ratio;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;

            //Console.WriteLine("Input Name");
            //string name = Console.ReadLine();
            //string lowerstring = name.ToLower();

            //foreach (char value in lowerstring.ToCharArray())
            //{
            //    if (isVowel(value))
            //    {
            //        counter++;
            //    }





            //}
            //Console.WriteLine(counter);

            ////////////////////
            ///

            //int a = 12;
            //int b = 30;
            //Console.WriteLine(a * b);

            ////////////////////////

            //string helloWorld = "Hello world";
            //int year = 2021;

            //helloWorld = helloWorld + year.ToString();


            //Class

            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));

        }
        static int FeetToInches(int feet)
        {
            return feet * 12;
        }
        static bool isVowel(char input)
        {
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                return true;
            }
            else
                return false;
        }
    }
}

