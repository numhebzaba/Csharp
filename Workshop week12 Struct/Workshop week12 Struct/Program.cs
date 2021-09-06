using System;

namespace Workshop_week12_Struct
{
    class Program
    {
        struct Profile
        {
            public string name;
            public double weight;
            public double height;
            public string career;
            public double BMI;
        }
        enum careerSalary
        {
            Programmer = 30000,
            Artist = 25000,
            Manager = 4000,  
        }
        static void Main(string[] args)
        {
            //Userinfo user1 = new Userinfo();
            //Userinfo user2 = new Userinfo();

            //RecieveInput(ref user1);
            //RecieveInput(ref user2);

            //Userinfo user1;
            //Userinfo user2;

            //user1.name = Console.ReadLine();
            //user1.weight = double.Parse(Console.ReadLine());
            //user1.height = double.Parse(Console.ReadLine());

            //user2.name = Console.ReadLine();
            //user2.weight = double.Parse(Console.ReadLine());
            //user2.height = double.Parse(Console.ReadLine());

            //Console.WriteLine("User Number : 1");
            //Console.WriteLine("Name : " + user1.name);
            //Console.WriteLine("Weight : " + user1.weight);
            //Console.WriteLine("Height : " + user1.height);

            /////////////////////////////////////////////////////

            int profileCount = int.Parse(Console.ReadLine());
            Profile[] profileArray = new Profile[profileCount];

            for (int i = 0; i < profileCount; i++)
            {
                RecieveInput(ref profileArray[i]);
            }

            for (int i = 0; i < profileCount; i++)
            {
                showProfileData(i + 1, profileArray[i]);
            }

            string action = Console.ReadLine();
            if(action == "FindMaxBMI")
            {
                double maxBMI = -9999999;
                int maxBMIIndex = -1;
                for(int i =0; i < profileCount; i++)
                {
                    if (profileArray[i].BMI > maxBMI)
                    {
                        maxBMI = profileArray[i].BMI;
                        maxBMIIndex = i;
                    }
                }
                Console.WriteLine("User Number : "+(maxBMIIndex+1));
                Console.WriteLine("Name : " + profileArray[maxBMIIndex].name);
                Console.WriteLine("BMI : "+ profileArray[maxBMIIndex].BMI);
            }
            else if (action == "FindMin BMI")
            {
                double minBMI = double.PositiveInfinity;
                int maxBMIIndex = -9999;
                for (int i = 0; i < profileCount; i++)
                {
                    if (profileArray[i].BMI < minBMI)
                    {
                        minBMI = profileArray[i].BMI;
                        maxBMIIndex = i;
                    }
                }
                Console.WriteLine("User Number : " + (maxBMIIndex + 1));
                Console.WriteLine("Name : " + profileArray[maxBMIIndex].name);
                Console.WriteLine("BMI : " + profileArray[maxBMIIndex].BMI);
            }




        }
        static void RecieveInput(ref Profile profile)
        {
            profile.name = Console.ReadLine();
            profile.weight = double.Parse(Console.ReadLine());
            profile.height = double.Parse(Console.ReadLine());
            profile.career = Console.ReadLine();

            profile.BMI = profile.weight/(Math.Pow(profile.height * 0.01, 2));
            Console.WriteLine();
        }static void showProfileData(int profileOrder, Profile profile)
        {
            Console.WriteLine("User Number : "+profileOrder);
            Console.WriteLine("Name : " + profile.name);
            Console.WriteLine("Weight : " + profile.weight);
            Console.WriteLine("Height : " + profile.height);
            Console.WriteLine("BMI : " + profile.BMI);

            switch (profile.career)
            {
                case "Programmer":
                    Console.WriteLine("Salary : " + (int)careerSalary.Programmer);
                    break;
                case "Artist":
                    Console.WriteLine("Salary : " + (int)careerSalary.Artist);
                    break;
                case "Manger":
                    Console.WriteLine("Salary : " + (int)careerSalary.Manager);
                    break;
            }
        }
    }
}
