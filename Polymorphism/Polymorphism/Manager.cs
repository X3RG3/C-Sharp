using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Manager : Employee
    {
        public Manager() { }

        public Manager(String Name,int Id,double BasicSalary, double Bonus) : base(Name,Id,BasicSalary)
        {
            this.Bonus = Bonus;
        }

        public double Bonus {  get; set; }

        public override double CalculateSalary()
        {
            return base.BasicSalary+Bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Bonus : " + Bonus);
            Console.WriteLine("Cumulative Salary : " + CalculateSalary());
        }
    }
}
