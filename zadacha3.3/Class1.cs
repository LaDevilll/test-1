using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3._3
{
    public class YearDaysCalculator
    {
        public static int CalculateDaysInYear(int year)
        {
            if (year <= 0)
            {
                throw new ArgumentException("Год должен быть положительным");
            }
            if (IsLeapYear(year))
            {
                return 366;
            }
            else
            {
                return 365;
            }
        }

        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
