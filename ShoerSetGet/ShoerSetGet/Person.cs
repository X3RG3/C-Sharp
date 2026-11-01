using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoerSetGet
{
    internal class Person
    {

        public Person()
        {
            Console.WriteLine("Empty cons created for person");
        }
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set {  age = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
        }
    }
}
