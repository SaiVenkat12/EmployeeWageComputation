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
            int isPresent = 1;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC1- Employee Attendance
            Random random = new Random();
            int empAttendance = random.Next(0, 2);

            if (empAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}