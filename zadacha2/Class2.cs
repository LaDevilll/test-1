using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    public class Class1
    {
        public static double[] Naidi2(double a, double b, double c)
        {
            if (Math.Abs(a) < 0.01)
            {
                throw new ArgumentException("Коэффициент а не может быть равен нулю");
            }
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[0]; 
            }
        }
    }
}
