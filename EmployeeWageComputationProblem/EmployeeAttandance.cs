﻿using System;

namespace EmployeeWageComputationProblem
{
    public class EmployeeAttandance
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, NO_OF_HRS = 8, IS_FULL_TIME = 1, IS_PART_TIME = 2;
        public void attandance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void DailyWage()
        {
            int wage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            switch (check)
            {
                case IS_FULL_TIME:
                    wage = NO_OF_HRS * WAGE_PER_HR;
                    break;
                case IS_PART_TIME:
                    wage = WAGE_PER_HR * (NO_OF_HRS / 2);
                    break;
            }
            Console.WriteLine("Daily wage of an employee is: " + wage);
        }

    }
}
