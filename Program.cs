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

        public static void CalculateDailyWage(int wagePerHour,int partTimeHour,int fullTimeHour,int workDayPerMonth,int wageCondition)
        {
            int totalAmount = 0;
            int totalHours = 0;
            for (int i = 0; i < workDayPerMonth; i++)
            {
                int final = Convert.ToInt32(checkPresentAbsent());
                if (final != 0)
                { 
                    final += Convert.ToInt32(PartTime()); 
                    if(final==1)
                    {
                        totalHours += partTimeHour;
                    }
                    else
                    {
                        totalHours += fullTimeHour;
                    }
                }


                if(totalHours<=wageCondition)
                {
                    totalAmount += switchCase(final, wagePerHour, fullTimeHour, partTimeHour);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\n\nThe employee earned " + totalAmount + " throughout the month.");
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
            int workDayPerMonth = 20;
            int wageCondition = 100;
            //for (int i = 0; i < workDayPerMonth; i++)
            //{
            //    Total_Amount+=CalculateDailyWage(wagePerHour,partTimeHour,fullDayHour);
            //}
            CalculateDailyWage(wagePerHour, partTimeHour, fullDayHour,workDayPerMonth,wageCondition);
            //Console.WriteLine("\n\nThe employee earned " + Total_Amount + " throughout the month.");
        }
    }
}