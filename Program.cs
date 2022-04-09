using System;

namespace EmployeeWageMultipleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            CalculateMonthlyWage();
        }
        public static int switchCase(int number, int wagePerHour, int fullDayHour, int partTimeHour)
        {
            int moneyEarned;
            switch (number)
            {
                case 0:
                    //Console.WriteLine("The employee is Absent, hence earned nothing.");
                    moneyEarned = 0;
                    return moneyEarned;
                case 1:
                    moneyEarned = wagePerHour * partTimeHour;
                    //Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                    return moneyEarned;
                case 2:
                    moneyEarned = wagePerHour * fullDayHour;
                    //Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                    return moneyEarned;
                default:
                    //Console.WriteLine("Out of context.");
                    return 0;
            }
        }

        public static int CalculateDailyWage(int wagePerHour,int partTimeHour,int fullDayHour)
        {
            int final = Convert.ToInt32(checkPresentAbsent());
            if (final != 0)
            { final += Convert.ToInt32(PartTime()); }
            int result=switchCase(final, wagePerHour, fullDayHour, partTimeHour);
            return result;
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

        public static void CalculateMonthlyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int partTimeHour = 4;
            int workDayPerMonth = 22;
            //int final = Convert.ToInt32(checkPresentAbsent());
            //if (final != 0)
            //{ final += Convert.ToInt32(PartTime()); }
            int Total_Amount = 0;
            for (int i = 0; i < workDayPerMonth; i++)
            {
                Total_Amount+=CalculateDailyWage(wagePerHour,partTimeHour,fullDayHour);
            }

            Console.WriteLine("\n\nThe employee earned " + Total_Amount + " throughout the month.");
        }
    }
}