using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal class Program
    {
        struct Student {
            public string name;
            public int age;
            public int id;

            public void display()
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Id : " + id);
                Console.WriteLine("Age : " + age);
            }

        }
        static void Main(string[] args)
        {
            Student s = new Student() ;
            Console.Write("Enter Your Name : ");
            s.name = Console.ReadLine();
            Console.Write("Enter your ID : ");
            s.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Age : ");
            s.age = int.Parse(Console.ReadLine());

            s.display();

        }
    }
}
