﻿using System;

namespace LeapYearTask
{
    public static class Year
    {
        /// <summary>
        /// Report if given year is a leap year.
        /// </summary>
        /// <param name="year">Given year.</param>
        /// <returns>True if given year is leap, false otherwise.</returns>
        public static bool IsLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            return year % 4 == 0;
        }
    }
}
