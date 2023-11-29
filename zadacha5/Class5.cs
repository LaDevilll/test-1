using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    public class DigitSumCalculator
    {
        public static int CalculateDigitSum(string numberStr)
        {
            int sum = 0;
            foreach (char digitChar in numberStr)
            {
                if (char.IsDigit(digitChar))
                {
                    // Преобразование символа в цифру и добавление к сумме
                    sum += int.Parse(digitChar.ToString());
                }
                else
                {
                    throw new ArgumentException("Должен содержать только цлые положительные числа");
                }
            }
            return sum;
        }
    }
}
