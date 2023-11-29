using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace zadacha4
{
    public class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email), "Адрес электронной почты не может быть нулевым");
            }
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
