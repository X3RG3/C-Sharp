using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    internal class Student : Person
    {
        private double cgpa;

        public Student()
        {

        }

        public void setCgpa(double cgpa)
        {
             this.cgpa = cgpa;
        }

        public double getCgpa()
        {
            return this.cgpa;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("CGPA : " + cgpa);
        }
    }
}
