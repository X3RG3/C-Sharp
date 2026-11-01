using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Designer : Employee
    {
        public Designer() { }
        public Designer(string Name, int Id, double BasicSalary,double ProjectBonus) : base(Name, Id, BasicSalary)
        {
            this.ProjectBonus = ProjectBonus;
        } 
        public double ProjectBonus {  get; set; }

        public override double CalculateSalary()
        {
            return base.BasicSalary+ProjectBonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Cumulative Salary : " + CalculateSalary());
        }
    }
}
