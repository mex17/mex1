﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yvonne
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ename, Reply;
            int Hours = 0, EID, Y;
            double Bonus = 0, Tax = 0, Salary = 0, SSF;
            double Gross_Salary = 0, Net_Salary = 0;
            Console.Write("EMPLOYEE PAYMENT ");
            Console.Write("\n\n");

            while (true)
            {
                Console.Write("enter employee's Name: ");
                Ename = Console.ReadLine();
                Console.Write("enter employee number:");
                EID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Choose The Type Of Employee");
                Console.WriteLine("1.monthly");
                Console.WriteLine("2.hourly");
                Console.WriteLine("3.evening");

                Y = Convert.ToInt32(Console.ReadLine());
                switch (Y)
                {

                    case 1:

                        Salary = 300000;
                        Tax = Salary * 18 / 100;
                        SSF = Salary * 3 / 100;
                        Net_Salary = Salary - Tax - SSF;
                        Console.Write("Employee records\n");
                        Console.WriteLine("************");
                        Console.Write("\n\n");
                        Console.WriteLine("Employee's Name:{0}.\n", Ename);
                        Console.WriteLine("Employee ID:{0}\n", EID);
                        Console.WriteLine("Gross salary: php{0:0.00}.", Salary);
                        Console.Write("\n\n");
                        Console.WriteLine("the tax of 18%:{0}\n", Tax);
                        Console.WriteLine("the social security fund is :{0}\n", SSF);
                        Console.WriteLine("Net salary:{0:0.00}.", Net_Salary);
                        break;

                    case 2:

                        Console.Write("enter hours worked:");
                        Hours = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter salary/hour: ");
                        Salary = Convert.ToDouble(Console.ReadLine());
                        Gross_Salary = (Hours * Salary);
                        Console.Write("\n");
                        Console.Write("\n");
                        Tax = Gross_Salary * 18 / 100;
                        Net_Salary = Gross_Salary - Tax;
                        Console.Write("Employee Records\n\n");
                        Console.WriteLine("***************");
                        Console.Write("\n\n");
                        Console.WriteLine("Employee's Name: {0}.", Ename);
                        Console.WriteLine("Employee ID:{0}\n", EID);
                        Console.WriteLine("Gross salary:{0:0.99}.", Gross_Salary);
                        Console.Write("\n\n");
                        Console.WriteLine("the tax of 18:{0}", Tax);
                        Console.WriteLine("Net Salary: php {0:0.00}.", Net_Salary);
                        break;

                    case 3:

                        Console.Write("enter hours worked:");
                        Hours = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter salary/hour: ");
                        Salary = Convert.ToDouble(Console.ReadLine());
                        Gross_Salary = (Hours * Salary);
                        Bonus = Gross_Salary * 0.15 / 100;

                        Console.Write("\n");
                        Console.WriteLine("gross salary: php{0:0.00}.", Gross_Salary);
                        Console.Write("\n");
                        Console.Write("\n");
                        Tax = Gross_Salary * 18 / 100;
                        Net_Salary = Gross_Salary - Tax + Bonus;
                        Console.Write("Employee Records\n\n");
                        Console.WriteLine("***************");
                        Console.Write("\n\n");
                        Console.WriteLine("Employee's Name: {0}.", Ename);
                        Console.WriteLine("Employee ID:{0}\n", EID);
                        Console.WriteLine("Gross salary:{0:0.99}.", Gross_Salary);
                        Console.WriteLine("evining bonus: php{0:0.00}", Bonus);
                        Console.Write("\n\n");
                        Console.WriteLine("the tax of 18:{0}", Tax);
                        Console.WriteLine("Net Salary: php {0:0.00}.", Net_Salary);
                        break;

                    default:
                        Console.WriteLine("invalid choise");
                        break;

                }
                Console.Write("do you want to continue? Y/N :");
                Reply = Console.ReadLine();
                if (Reply == "y")
                {
                    continue;
                    Console.WriteLine("\n");

                }
                else if (Reply == "n")
                {
                    Console.WriteLine("exit");
                    break;
                }
            }
        }
    }
}
