using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    public class NNN
    {
        public static string Naidi(int n)
        {
            if (n < 1 || n > 26)
            {
                throw new ArgumentException("N дожно быть от 1 до 26");
            }
            char a = 'A';
            return new string(Enumerable.Range(a, n).Select(c => (char)c).ToArray());
        }
    }
}
