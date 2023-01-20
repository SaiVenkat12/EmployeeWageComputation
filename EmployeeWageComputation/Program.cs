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
            const int isFullTime = 1;
            const int isPartTime = 2;
            const int empWagePerHr = 20;
            const int empWorkinDaysPerMonth = 20;
            const int empTotalWorkingHrs = 100;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int empDailyWage = 0;
            int empMontlyWage = 0;
            int totalWorkingDays = 0;


            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC1- Employee Attendance
            Random random = new Random();
            //UC7-MaxHrs
            while ( totalWorkingDays<empWorkinDaysPerMonth && totalEmpHrs<empTotalWorkingHrs)
            {
                int empAttendance = random.Next(0, 3);
                //UC3- Add Part Time Employee
                //UC4- Switch Case
                switch (empAttendance)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingDays++;
                totalEmpHrs += empHrs;
            }
            //UC2- Employee Daily Wage
            //UC5- Employee Monthly Wage
            empMontlyWage = empWagePerHr * totalEmpHrs;
            Console.WriteLine("Total Number of Hours is  " + totalEmpHrs + " Total Number of days is " + totalWorkingDays);
            Console.WriteLine("Montly Wage of Emplyoee is " + empMontlyWage);
            Console.ReadLine();
        }
    }
}