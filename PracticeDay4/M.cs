using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay4
{
    internal class M
    {
        enum weekdays
        {
            sat, sun, mon, tue, wed, thu, fri
        }
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.fri);
            Console.WriteLine((int)weekdays.wed);
            Console.WriteLine();

            Car car1 = new Car();
            car1.setLid(1);
            car1.setModel("Supra");
            car1.setCc(2997);

            Car car2 = new Car();
            car2.setLid(2);
            car2.setModel("GTR");
            car2.setCc(3799);
            car2.showDetails();

            Console.ReadKey();
        }
    }
}
