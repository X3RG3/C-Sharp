using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Developer : Employee
    {
        public Developer() { }

        public Developer(string Name, int Id,double BasicSalary,int OvertimeHours,double HourlyRate) : base(Name,Id,BasicSalary)
        {
            this.OvertimeHours = OvertimeHours;
            this.HourlyRate = HourlyRate;
        }
        public int OvertimeHours {  get; set; }
        public double HourlyRate {  get; set; }

        public override double CalculateSalary()
        {
            return base.BasicSalary + (OvertimeHours * HourlyRate);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Overtime Hours : " + OvertimeHours);
            Console.WriteLine("Hourly Rate : " + HourlyRate);
            Console.WriteLine("Cumulative Salary : " + CalculateSalary());
        }
    }
}
