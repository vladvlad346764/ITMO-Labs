using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay2
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
    class WhatDay2
    {
        static void Main(string[] args)
        {
            try
            {
                var DaysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                Console.Write("Please enter a day number between 1 and 365: ");
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);
                if (dayNum < 1 || dayNum > 365)
                {
                    throw new System.ArgumentOutOfRangeException("Day out of range");
                }
                int monthNum = 0;

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
