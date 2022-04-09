using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageMultipleCompany
{
    public class CalculateWage
    {
        private string companyName;
        private int wagePerHour;
        private int fullTimeHour;
        private int partTimeHour;
        private int workDayPerMonth;
        private int maximumHoursPerMonth;

        public CalculateWage(string name,int wagePerHour,int fullTimeHour,int workDayPerMonth,int maximumHoursPerMonth)
        {
            this.companyName = name;
            this.wagePerHour = wagePerHour;
            this.fullTimeHour = fullTimeHour;
            this.partTimeHour = fullTimeHour / 2;
            this.workDayPerMonth = workDayPerMonth;
            this.maximumHoursPerMonth = maximumHoursPerMonth;
        }

        public void EmployeeWage()
        {
            int totalWage = 0;
            int totalHours = 0;
            int totalDays = 0;

            while(totalHours<=maximumHoursPerMonth && totalDays<=workDayPerMonth)
            {
                int value = Convert.ToInt32(checkPresentAbsent());
                if (value != 0)
                {
                    value += Convert.ToInt32(PartTime());
                    if (value == 1)
                    {
                        totalHours += partTimeHour;
                    }
                    else
                    {
                        totalHours += fullTimeHour;
                    }
                }

                if (totalHours <= maximumHoursPerMonth)
                {
                    totalWage += switchCase(value, wagePerHour, fullTimeHour, partTimeHour);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\nThe employee earned " + totalWage + " throughout the month in "+this.companyName+".");
        }

        private static int switchCase(int number, int wagePerHour, int fullDayHour, int partTimeHour)
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

        //public static void CalculateDailyWage(int wagePerHour, int partTimeHour, int fullTimeHour, int workDayPerMonth, int wageCondition)
        //{
        //    int totalAmount = 0;
        //    int totalHours = 0;
        //    for (int i = 0; i < workDayPerMonth; i++)
        //    {
        //        int final = Convert.ToInt32(checkPresentAbsent());
        //        if (final != 0)
        //        {
        //            final += Convert.ToInt32(PartTime());
        //            if (final == 1)
        //            {
        //                totalHours += partTimeHour;
        //            }
        //            else
        //            {
        //                totalHours += fullTimeHour;
        //            }
        //        }


        //        if (totalHours <= wageCondition)
        //        {
        //            totalAmount += switchCase(final, wagePerHour, fullTimeHour, partTimeHour);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    Console.WriteLine("\n\nThe employee earned " + totalAmount + " throughout the month.");
        //}

        private static bool PartTime()
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

        private static bool checkPresentAbsent()
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

        //public void CalculateMonthlyWage()
        //{
        //    int wagePerHour = 20;
        //    int fullDayHour = 8;
        //    int partTimeHour = 4;
        //    int workDayPerMonth = 20;
        //    int wageCondition = 100;
        //    //for (int i = 0; i < workDayPerMonth; i++)
        //    //{
        //    //    Total_Amount+=CalculateDailyWage(wagePerHour,partTimeHour,fullDayHour);
        //    //}
        //    CalculateDailyWage(wagePerHour, partTimeHour, fullDayHour, workDayPerMonth, wageCondition);
        //    //Console.WriteLine("\n\nThe employee earned " + Total_Amount + " throughout the month.");
        //}
    }
}
