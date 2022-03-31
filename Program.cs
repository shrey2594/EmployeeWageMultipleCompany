using System;

namespace EmployeeWageMultipleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            CalculateDailyWage();
        }

        public static bool checkPresentAbsent()
        {
            int isPresent = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPresent)
            {
                Console.WriteLine("Employee is present.");
                return true;
            }
            else
            {
                Console.WriteLine("Employee is absent.");
                return false;
            }
        }

        public static void CalculateDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int moneyEarned;
            if (checkPresentAbsent() == true)
            {
                moneyEarned = wagePerHour * fullDayHour;
                Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
            }
            else
            {
                Console.WriteLine("The employee is Absent, hence earned nothing.");
            }
        }
    }

}