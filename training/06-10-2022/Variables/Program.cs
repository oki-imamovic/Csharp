using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //All types of Variables in C#

            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);
             */


            /*
            //Simple Math

            int x = 24;
            int y = 31;
            int z = x + y;
            Console.WriteLine(z);
            */

            /*
            //String

            string firstName = "Ohran";
            string lastName = "Imamovic";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            */


            /* 
            //User Input
            
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            */


            /*
            //User Input numbers have to be converted ToInt23
            
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            */


            /*
            //Assingnments
            
            int a = 5;
            a += 3;
            Console.WriteLine(a);

            int b = 5;
            b -= 3;
            Console.WriteLine(b);

            int c = 5;
            c *= 3;
            Console.WriteLine(c);

            int d = 5;
            d /= 3;
            Console.WriteLine(d);

            int e = 5;
            e %= 3;
            Console.WriteLine(e);

            int f = 5;
            f &= 3;
            Console.WriteLine(f);

            int g = 5;
            g |= 3;
            Console.WriteLine(g);

            int h = 5;
            h ^= 3;
            Console.WriteLine(h);

            int j = 5;
            j >>= 3;
            Console.WriteLine(j);

            int l = 5;
            l <<= 3;
            Console.WriteLine(l);
            */


            /*
            Math Methods
            
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));
            */


            /*
            String Methods
            
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt[4]);
            Console.WriteLine(txt.IndexOf("e"));

            string name = "Ohran Imamovic";
            int charPos = name.IndexOf("I");
            string lastName = name.Substring(charPos);
            Console.WriteLine(lastName);
            */





            /*
            String Interpolation

            string firstName = "Ohran";
            string lastName = "Imamovic";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            */


            /*
            If Else 
             
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            */


            /*
            Else If

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            */


            /*
            Switch

            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            */


            /*
            Break
             
            int day = 2;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            */

        }
    }
}
