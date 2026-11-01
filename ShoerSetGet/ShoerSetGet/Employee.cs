using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoerSetGet
{
    internal class Employee : Person
    {

        public Employee() 
        {
            Console.WriteLine("Empty cons Created for Employee.");
        }
        //More Short SetGet

        public double Salary {  get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Salary : " + Salary);
        }


    }
}
