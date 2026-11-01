using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoerSetGet
{
    internal class M
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Enter Info for Person: ");
            Console.Write("Enter Name : ");
            p1.Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            p1.Age = int.Parse(Console.ReadLine());


            Employee e1 = new Employee();
            Console.WriteLine("Enter Info for Employee : ");
            Console.Write("Enter Name : ");
            e1.Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            e1.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary : ");
            e1.Salary=double.Parse(Console.ReadLine());

            p1.Print();
            e1.Print();
        }
    }
}
