using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay5
{
    internal class Student : Person
    {
        private string department;
        private double cgpa;

        public Student()
        {
            Console.WriteLine("Empty Constructor Created.");
        }

        public Student(string name, int age, string job,string department,double cgpa) : base(name,age,job) 
        {
            this.department = department;
            this.cgpa = cgpa;
            Console.WriteLine("pera Constructor Created student.");
        }
    }
}
