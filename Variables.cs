using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Variables
    {
        public static (int, int) DevineAndRemainder()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                throw new Exception("b haven't to be zero");
            }
            return (a / b, a % b);
        }
        public static double GetSolutionTheEquation(double a, double b)
        {
            if (a==b)
            {
                throw new Exception("<a> can't be equal <b>");
            }

            double result = -((5 * a) + (b * b)) / (b - a);
            return result;
        }
        public static void SwapStrings(ref string result1, ref string result2)
        {
            if (result1==result2)
            {
                throw new Exception("entered the same values");
            }
            string result3 = result1;
            result1 = result2;
            result2 = result3;
        
        }
        public static double GetSolutionLinearEquation(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new Exception("arguments can't be equal 0");
            }
            double result = (c - b) / a;
            return result;
        }
        public static string GetSolutionStraightLineEquation(double y1, double y2, double x1, double x2)
        {
            if (x2 == x1)
            {
                throw new Exception("<x1> can't be equal <x2>");
            }
            else if (y1 == y2)
            {
                throw new Exception("<y1> can't be equal <y2>");
            }
            double k = (y1 - y2) / (x1 - x2);
            double n = y2 - k * x2;
            string s = $"Уравнение Y= + {k}x + {n}";
            return s;

        }
    }
}
