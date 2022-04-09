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
        public static void switchCase(int number, int wagePerHour, int fullDayHour, int partTimeHour)
        {
            int moneyEarned;
            switch (number)
            {
                case 0:
                    Console.WriteLine("The employee is Absent, hence earned nothing.");
                    break;
                case 1:
                    moneyEarned = wagePerHour * partTimeHour;
                    Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                    break;
                case 2:
                    moneyEarned = wagePerHour * fullDayHour;
                    Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                    break;
                default:
                    Console.WriteLine("Out of context.");
                    break;
            }
        }

        public static void CalculateDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int partTimeHour = 4;
            int final = Convert.ToInt32(checkPresentAbsent());
            if (final != 0)
            { final += Convert.ToInt32(PartTime()); }
            switchCase(final, wagePerHour, fullDayHour, partTimeHour);
        }

        public static bool PartTime()
        {
            int isPartTime = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPartTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkPresentAbsent()
        {
            int isPresent = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPresent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}