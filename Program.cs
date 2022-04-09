using System;

namespace EmployeeWageMultipleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            CalculateWage calculate = new CalculateWage();
            calculate.CalculateMonthlyWage();
        }
        
    }
}