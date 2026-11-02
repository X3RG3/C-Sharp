using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class M
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Information For Someone: ");
            Someone someone = new Someone();
            Student student = new Student();
            Console.Write("Enter Name: ");
            someone.setName(Console.ReadLine());
            int age = 0;
            


            while (age < 10)
            {
                Console.Write("Enter Age: ");
                age = int.Parse(Console.ReadLine());
                if (age > 10)
                {
                    someone.setAge(age);
                }
                else
                {
                    continue;
                }
                
            }
            Console.Write("Enter Age: ");
            
            Console.WriteLine("Enter Information For Student: ");
            Console.Write("Enter Name: ");
            student.setName(Console.ReadLine());
            age = 0;
            while (age < 10)
            {
                Console.Write("Enter Age: ");
                age = int.Parse(Console.ReadLine());
                if (age > 10)
                {
                    student.setAge(age);
                }
                else
                {
                    continue;
                }

            }
            Console.Write("Enter Id : ");
            student.setStudentId(int.Parse(Console.ReadLine()));
            Console.Write("Enter CGPA: ");
            student.setCgpa(double.Parse(Console.ReadLine()));


            someone.Print();
            Console.WriteLine("---------------------------");
            student.Print();


            Console.ReadKey();
        }
    }
}
