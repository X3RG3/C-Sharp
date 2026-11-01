using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    internal class Person
    {
        private int id;
        private string name;

        public Person()
        {

        }
        public void setID(int id)
        {
            this.id = id;
        }

        public void setName(string name) 
        { 
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public int getId()
        {
            return this.id;
        }

        public virtual void Print()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
        }
    }
}
