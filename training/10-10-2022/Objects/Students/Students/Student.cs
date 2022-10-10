using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) 
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //Method
        public bool HasHonor() 
        {
            if (gpa >= 3.5) 
            {
                return true;
            }
            return false;
        }
        
    }
}
