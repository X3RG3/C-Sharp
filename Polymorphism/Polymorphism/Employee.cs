using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Employee
    {

        public Employee() { }
        public Employee(String Name, int Id, double BasicSalary) 
        {
            this.Name = Name;
            this.Id = Id;
            this.BasicSalary = BasicSalary;
        }
        public string Name {  get; set; }
        public int Id {  get; set; }
        public double BasicSalary {  get; set; }

        public virtual double CalculateSalary()
        {

            return this.BasicSalary;
        }

        public virtual void DisplayInfo()
        {
            
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Basic Salary : " + BasicSalary);
        }
    }
}
