using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay3
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the year");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;


                if (isLeapYear) { Console.WriteLine("IS a leap year"); }
                else Console.WriteLine("is NOT a leap year");

                //1
                var DaysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                //2
                var DaysInLeapMonths = new List<int> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


                Console.Write("Please enter a day number between 1 and {0}: ", maxDayNum);
                line = Console.ReadLine();
                int dayNum = int.Parse(line);


                if (dayNum < 1 || dayNum > 365)
                {
                    throw new System.ArgumentOutOfRangeException("Day out of range");
                }



                int monthNum = 0;
                if (isLeapYear)
                {

                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }

                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }


                //
                string monthName;
                //
                MonthName temp = (MonthName)monthNum;

                monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);

            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }

            Console.ReadKey();
        }
    }
}
