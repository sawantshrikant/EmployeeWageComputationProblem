using System;
namespace EmployeeWageComputationProblem
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem ");
            EmployeeAttandance EmployeeAttandance = new EmployeeAttandance();
            EmployeeAttandance.attandance();
            EmployeeAttandance.TotalWorkingHours();
        }
    }
}