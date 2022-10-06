using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //While Loop

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            

            //Do While

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);


            */

            //Break and Continue While Loop

            /*
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
            */


            /*
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
            */



            /*
            //For Loop

            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine(k);
            }


            for (int l = 0; l <= 10; l = l + 2)
            {
                Console.WriteLine(l);
            }

            //For Each

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }
            */


            //C# Break

            /*
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */


            //C# Continue

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    continue;
                }
                else 
                {
                    i += 4;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
