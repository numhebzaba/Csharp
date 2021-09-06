using System;

namespace fixcodeSession
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input Celsius : ");
            //float c = float.Parse(Console.ReadLine());
            ////float f = (9.0f * c / 5.0f) + 32.0f;
            //float f = CelsiusToFahrenit(c);
            //Console.WriteLine("celsius : {0} => fahrenheit : {1} ",c,f);

            double max = double.NegativeInfinity;

            for (int i = 0; i < 8; i++) 
            {
                double inputnumber = double.Parse(Console.ReadLine());
                if (inputnumber > max)
                    max = inputnumber;
            
            }
        }
        static float CelsiusToFahrenit(float celsius) 
        {
            float result =(9.0f * celsius / 5.0f) + 32.0f;
            return result;
        }

    }
}
