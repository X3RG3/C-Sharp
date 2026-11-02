using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Someone
    {
        private string name;
        private int age;

        public Someone()
        {

        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age) 
        { 
            this.age = age;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
        }





    }
}
