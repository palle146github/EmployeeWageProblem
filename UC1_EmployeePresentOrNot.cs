using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class UC1_EmployeePresentOrNot // this class is to check weather the employee present or not
    {
        public static void EmployeeAttendance() // method declaration of use case 1
        {
            int IS_FULL_TIME = 1;
            Random random = new Random(); // random function to generate random numbers
            int empcheck = random.Next(0, 2);// this will assign random number from 0 to 1
            if (empcheck == IS_FULL_TIME)// checking condition for true
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
