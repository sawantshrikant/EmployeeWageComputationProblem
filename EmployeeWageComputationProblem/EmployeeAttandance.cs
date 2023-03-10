using System;

namespace EmployeeWageComputationProblem
{
    public class EmployeeAttandance
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, NO_OF_HRS = 8;
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
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                wage = WAGE_PER_HR * NO_OF_HRS;
            Console.WriteLine("Daily wage of an employee is: " + wage);
        }
    }
}
