using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // printing
            Console.WriteLine("Hello");
            Console.WriteLine("Ayon");
            Console.Write("Hello World");




            // Data types
            int a = 10;
            float b = 3.94f;
            double c = 8.34;
            string d = "Hello!!";

            // Data type printing in different ways

            Console.WriteLine("Values : {0} {1} {2}", a, b, c);

            Console.WriteLine("Values : " + a + " " + b + " " + c);

            Console.WriteLine($"d is : {d}");

            // Taking Input (string)

            Console.Write("Enter Your Name : ");
            string aa = Console.ReadLine();
            Console.WriteLine("Your Name is : " + aa);

            // Taking Input (int)

            Console.Write("Enter your age : ");

            int bb = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age is : " + bb);
            
            
            // condition

            int sd = 10;

            if (sd > 18) { Console.WriteLine("Greater than 18"); }
            else if (sd == 10)
            {
                Console.WriteLine("Equal to 10");
            }
            else {
                Console.WriteLine("Invalid");
            }
            
            //switch case

            int bd = 2;
            switch (bd)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            int i;
            for(i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }

            while (i <= 10) { 
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 15);


            // array

            Console.WriteLine("Enter 5 Student Names : ");

            string[] students = new string[5];

            for (i = 0; i < 5; i++)
            {
                students[i] = Console.ReadLine();
            }

            for (i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student : " + i + " : " + students[i]);
            }

            // for each

            string[] courses = new string[5];
            Console.WriteLine("Enter 5 Courses : ");
            for (i=0;i< courses.Length;i++) { 
                courses[i] = Console.ReadLine();
            }

            foreach (var s in courses) { 
                Console.WriteLine(s);
            }


            Console.ReadKey();
        }
    }
}
