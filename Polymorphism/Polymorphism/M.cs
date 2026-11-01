using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Polymorphism
{
    internal class M
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[50];
             int count = 0;
             int choice;
             int empType;
            do
            {
                Console.WriteLine("\n===== EMPLOYEE MANAGEMENT =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Search Employee");
                Console.WriteLine("4. Highest Salary");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select Employee Type: ");
                        Console.WriteLine("1.Manager");
                        Console.WriteLine("2.Developer");
                        Console.WriteLine("3.Designer");

                        Console.WriteLine();
                        Console.Write("Enter Choice: ");
                        empType = int.Parse(Console.ReadLine());
                        string name;
                        int id,ovtH;
                        double basicSalary,hourlyR,projBon,bon;
                        switch (empType)
                        {
                            case 1:
                                
                                Console.Write("Enter Name: ");
                                name = Console.ReadLine();
                                Console.Write("Enter ID : ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Basic Salary : ");
                                basicSalary = double.Parse(Console.ReadLine());
                                Console.Write("Bonus : ");
                                bon = double.Parse(Console.ReadLine());

                                employees[count++] = new Manager(name,id,basicSalary,bon);
                                break;
                            case 2:
                                Console.Write("Enter Name: ");
                                name = Console.ReadLine();
                                Console.Write("Enter ID : ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Basic Salary : ");
                                basicSalary = double.Parse(Console.ReadLine());
                                Console.Write("Enter Overtime Hours : ");
                                ovtH = int.Parse(Console.ReadLine());
                                Console.Write("Enter Hourly Rate : ");
                                hourlyR = double.Parse(Console.ReadLine());

                                employees[count++] = new Developer(name, id, basicSalary,ovtH,hourlyR);
                                break;
                            case 3:
                                Console.Write("Enter Name: ");
                                name = Console.ReadLine();
                                Console.Write("Enter ID : ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Basic Salary : ");
                                basicSalary = double.Parse(Console.ReadLine());

                                Console.Write("Enter Project Bonus : ");
                                projBon = double.Parse(Console.ReadLine());

                                employees[count++] = new Designer(name, id, basicSalary,projBon);
                                break;
                            default:
                                Console.WriteLine("Invalid Input!");
                                break;
                        }
                        break;
                    case 2:
                        for(int i = 0; i < count; i++)
                        {
                            Console.WriteLine("========== EMPLOYEE " + (i + 1) + "==========");
                            employees[i].DisplayInfo();
                            Console.WriteLine("=================================");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        if(count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            int Fid;
                            Console.Write("Enter ID to Find : ");
                            Fid = int.Parse(Console.ReadLine());
                            bool found = false;
                            int idx = -1 ;
                            for(int i = 0; i < count; i++)
                            {
                                if(Fid == employees[i].Id)
                                {   
                                    found = true;
                                    idx = i;
                                    break;
                                }

                            }
                            if (found)
                            {
                                Console.WriteLine("Employee Found : ");
                                employees[idx].DisplayInfo();
                            }
                            else
                            {
                                Console.WriteLine("Employee not Found!!");
                            }
                        }
                        break;
                    case 4:
                        double maxSal = employees[0].CalculateSalary();
                        for(int i = 0; i < count; i++)
                        {
                            maxSal = Math.Max(maxSal, employees[i].CalculateSalary());
                        }
                        Console.WriteLine("Maximum salary : " + maxSal);
                        break;
                    case 5:
                        Console.WriteLine("Good Bye :D ");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }

            }
            while(choice !=5);
            Console.ReadKey();
        }
    }
}
