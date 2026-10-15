using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay4
{
    internal class Car
    {
        private int lid;
        private string model;
        private int cc;

        public void setLid(int lid)
        {
            this.lid = lid;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public void setCc(int cc)
        {
            this.cc = cc;
        }

        public int getLid()
        {
            return this.lid;
        }
        public string getModel()
        {
            return this.model;
        }

        public int getCc()
        {
            return this.cc;
        }

        public void showDetails()
        {
            Console.WriteLine("Lid : " + lid);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("CC : " + cc);
        }
        enum weekdays
        {
            sat,sun,mon,tue,wed,thu,fri
        }
        
    }
}
