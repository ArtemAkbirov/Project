using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class HomeworkFirst
    {
        public static (int, int) Task1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            return (a / b, a%b);
        }
        public static double Task2(double a, double b)
        {
            double result = -((5 * a) + (b * b)) / (b - a);
            return result;
        }
        public static void Task3(ref string result1, ref string result2)
        {
            string result3 = result1;
            result1 = result2;
            result2 = result3;
        
        }
        public static double Task4(double a, double b, double c)
        {
            double result = (c - b) / a;
            return result;
        }
        public static string Task5(double y1, double y2, double x1, double x2)
        {
            double k = (y1 - y2) / (x1 - x2);
            double n = y2 - k * x2;
            string s = $"Уравнение Y= + {k}x + {n}";
            return s;

        }
    }
}
