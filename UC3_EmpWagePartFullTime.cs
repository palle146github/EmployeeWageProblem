﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class UC3_EmpWagePartFullTime
    {
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static void EmpWagePartFullTime()
        {
            int empwage = 0;
            int emphours = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);

            if (empcheck == IS_FULL_TIME)
            {
                emphours = 8;
            }
            else if (empcheck == IS_PART_TIME)
            {
                emphours = 4;
            }
            else
            {
                emphours = 0;
            }
            empwage = emphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage "+empwage);
        }
    }
}
