using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3
{
    class WhatDay
    {
        static System.Collections.ICollection DaysInMonths
        = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            //1 задание
            //ifcase();
            //forcase();
            //2 задание
            //WhatDayWExceptions.forcase();
            //3 задание
            //WhatDayWYear.forcase();
            
        }
        static void ifcase()
        {
            int monthNum = 0;

            Console.WriteLine("Please enter the day of the year");
            int dayNum = int.Parse(Console.ReadLine());
            ////////////////////////////////////////////////////////////////////
            ////// Uncomment the code below  before Calculating           //////
            /////  the month and day pair from a day number               //////
            ////////////////////////////////////////////////////////////////////

            if (dayNum <= 31)
            { // January
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 28)
            { // February
                goto End;
            }
            else
            {
                dayNum -= 28;
                monthNum++;
            }

            if (dayNum <= 31)
            { // March
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30)
            { // April
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31)
            { // May
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }


            if (dayNum <= 30)
            { // June
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31)
            { // July
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 31)
            { // August
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30)
            { // September
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31)
            { // October
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30)
            { // November
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
        End:

            //////////////////////////////////////////////////////////////
            // TODO: Implement if statements for November and December ///
            //////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////
            // TODO:												  ////
            //		Add an identifer label End below and              ////
            //		declare string variable							  ////
            //////////////////////////////////////////////////////////////
            String monthName;
            switch (monthNum)
            {
                case 0:
                    monthName = "January"; break;
                case 1:
                    monthName = "February"; break;
                case 2:
                    monthName = "March"; break;
                case 3:
                    monthName = "April"; break;
                case 4:
                    monthName = "May"; break;
                case 5:
                    monthName = "June"; break;
                case 6:
                    monthName = "July"; break;
                case 7:
                    monthName = "August"; break;
                case 8:
                    monthName = "September"; break;
                case 9:
                    monthName = "October"; break;
                case 10:
                    monthName = "November"; break;
                case 11:
                    monthName = "December"; break;
                default:
                    monthName = "Not done yet"; break;

                    //////////////////////////////////////////////////////////////////
                    // TODO: Implement the case 10 and case 11 for November         //
                    //       and December											//
                    //       Add a default label									//
                    //////////////////////////////////////////////////////////////////

            }
            Console.WriteLine("{0} {1}", dayNum, monthName);
            Console.ReadKey();
        }

        public enum MonthName
        {
            January = 0,
            February = 1,
            March = 2,
            April = 3,
            May = 4,
            June = 5,
            July = 6,
            Augest = 7,
            September = 8,
            October = 9,
            November = 10,
            December = 11

        }
        static void forcase()
        {
            int monthNum = 0;

            Console.WriteLine("Please enter the day of the year");
            int dayNum = int.Parse(Console.ReadLine());

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

            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
            Console.WriteLine("{0} {1}", dayNum, monthName);
            Console.ReadKey();
        }
    }
    class WhatDayWExceptions
    {
        public enum MonthName
        {
            January = 0,
            February = 1,
            March = 2,
            April = 3,
            May = 4,
            June = 5,
            July = 6,
            Augest = 7,
            September = 8,
            October = 9,
            November = 10,
            December = 11

        }
        static System.Collections.ICollection DaysInMonths
        = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public static void forcase()
        {
            try
            {
                int monthNum = 0;

                Console.WriteLine("Please enter the day of the year");
                int dayNum = int.Parse(Console.ReadLine());

                if (dayNum < 1 || dayNum > 365) { throw new ArgumentOutOfRangeException("Day out of range"); }

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

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);
                Console.ReadKey();
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
                Console.ReadKey();
            }
        }
    }

    class WhatDayWYear
    {
        public enum MonthName
        {
            January = 0,
            February = 1,
            March = 2,
            April = 3,
            May = 4,
            June = 5,
            July = 6,
            Augest = 7,
            September = 8,
            October = 9,
            November = 10,
            December = 11

        }
        static System.Collections.ICollection DaysInMonths
        = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static System.Collections.ICollection DaysInLeapMonths
        = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public static void forcase()
        {
            try
            {
                int monthNum = 0;
                //year
                Console.WriteLine("Please enter the year:");
                int yearNum = int.Parse(Console.ReadLine());

                Boolean isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;

                //day
                Console.WriteLine("Please enter the day of the year:");
                int dayNum = int.Parse(Console.ReadLine());

                if (dayNum < 1 || dayNum > maxDayNum) { throw new ArgumentOutOfRangeException("Day out of range"); }

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

               MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);
                Console.ReadKey();
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
                Console.ReadKey();
            }
        }
    }
}
