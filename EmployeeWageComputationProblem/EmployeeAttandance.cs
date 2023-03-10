using System;

namespace EmployeeWageComputationProblem
{
    public class EmployeeAttandance
    {
        const int IS_PRESENT = 1;
        public void attandance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
