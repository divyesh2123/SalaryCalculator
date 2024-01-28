using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please Enter Basic Salary");
            int basicsalary = Convert.ToInt32(Console.ReadLine());

            int DA = basicsalary*10/100;
            int HRA = basicsalary * 50 / 100;

            int netSalary = basicsalary + HRA + DA;

            int tax = netSalary *10/100;    


            int inhandSalary = netSalary- tax;


            Console.WriteLine("FirstName " + firstName);
            Console.WriteLine("LastName " + lastName);
            Console.WriteLine("BasicSalary " + basicsalary);
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("Tax " + tax);
            Console.WriteLine("DA " + DA);
            Console.WriteLine("NetSalary " + netSalary);
            Console.WriteLine("InhandSalary" + inhandSalary);

            Console.ReadKey();



        }
    }
}
