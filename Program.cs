using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class Program // this is the main program here all the other use cases are called
    {
        static void Main(string[] args)
        {
            UC1_EmployeePresentOrNot.EmployeeAttendance();
            UC2_EmployeeDailyWage.EmployeeWage();
            UC3_EmpWagePartFullTime.EmpWagePartFullTime();
            UC4_EmpWageSwitchCase.EmpWageSwitchCase();
            UC5_EmpWageMaxWorkMonth.EmpWageMaxWorkMonth();
            UC6_EmpWageHourMaxDaysMonth.EmpWageHourMaxDaysMonth();
            Console.ReadKey();
        }
    }
}
