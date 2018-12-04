using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, OPT;
            var result = new Calculate();
            Console.WriteLine("enter first number");
            NUM1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            
            
            NUM2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n here is the option: \n");
            Console.Write("1-ADD. \n2-substraction. \n3-MULTIPLICATION. \n4-DIVISION. \n5-exit \n");
            Console.Write("\n input your choice\n");
            OPT = Convert.ToInt32(Console.ReadLine());
            switch(OPT)
            {
                case 1:
                    Console.WriteLine("the sum of {0} and {1} is equal to {2}", NUM1, NUM2, result.ADD(NUM1, NUM2));
                    break;
                case 2:
                    Console.WriteLine("the difference of {0} and {1} is equal to {2}", NUM1, NUM2, result.SUBSTRACT(NUM1, NUM2));
                    break;
                case 3:
                    Console.WriteLine("the product of {0} and {1} is equal to {2}", NUM1, NUM2, result.MULTIPLY(NUM1, NUM2));
                    break;
                case 4:
                    Console.WriteLine("the quotient of {0} and {1} is equal to {2}", NUM1, NUM2, result.DIVIDE(NUM1, NUM2));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
           
            
            
            






        }
    }
}