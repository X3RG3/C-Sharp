using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay5
{
    internal class Person
    {
        private string name;
        private int age;
        private string job;

        public  Person()
        {
            Console.WriteLine("Empty Constructor Created.");
        }

        public Person(string name, int age, string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;

            Console.WriteLine("Perameterized Constructor created person. ");
        }


    }
}
