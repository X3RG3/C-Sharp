using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Someone
    {
        private int studentId;
        private double cgpa;

        public Student()
        {

        }
        public void setStudentId(int studentId)
        {
            this.studentId = studentId;
        }

        public void setCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public int getStudentId()
        {
            return this.studentId;
        }

        public double getCgpa()
        {
            return this.cgpa;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Student ID : " + studentId);
            Console.WriteLine("CGPA : " + cgpa);
        }
    }
}
