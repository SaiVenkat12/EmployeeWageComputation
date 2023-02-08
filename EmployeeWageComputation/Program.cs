using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC7-Use Class Method and Variables
            //UC8-Multiple companies
            EmpWageBuilder Tata =new EmpWageBuilder("Tata", 30, 16, 60);
            EmpWageBuilder Google = new EmpWageBuilder("Google", 20, 15, 80);
            EmpWageBuilder Apple = new EmpWageBuilder("Apple", 15, 18, 100);

            Tata.EmpWage();
            Console.WriteLine(Tata.ToString());
            Google.EmpWage();
            Console.WriteLine(Apple.ToString());
            Apple.EmpWage();
            Console.WriteLine(Google.ToString());

            Console.ReadLine();
        }             
    }
}