using System;

namespace EmployeeWageMultipleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            CalculateWage Deloitte = new CalculateWage("Deloitte", 40, 8, 24, 100);
            Deloitte.EmployeeWage();
            CalculateWage TCS = new CalculateWage("TCS",30,10,25,100);
            TCS.EmployeeWage();
        }
    }
}