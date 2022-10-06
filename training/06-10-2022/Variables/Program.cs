using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
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


            int x = 24;
            int y = 31;
            int z = x + y;
            Console.WriteLine(z);

            string firstName = "Ohran";
            string lastName = "Imamovic";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
