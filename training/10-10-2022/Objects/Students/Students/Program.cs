using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            //Object Methods
            Student student1 = new Student("Ohran Imamovic", "IT", 3.2);
            Student student2 = new Student("Eric Longshoot", "Medicine", 3.8);

            Console.WriteLine(student1.HasHonor());
            Console.WriteLine(student2.HasHonor());
        }
    }
}
