using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Cycles
    {
        public static int Exponentiation(int a, int b)
        {
            if (b < 0)
            {
                throw new Exception("<b> can't be less than zero");
            }
            int result = 1;
            if (b == 0)
            {
                result = 1;
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    result *= a;
                }
            }
            return result;
        }
        //public static int[] Task2(int[] a)
        //{
        //    {
        //        int b = 2;
        //        int[] result = new int[a.Length];
        //        for (int i = 0; i < a.Length; i ++)
        //        {
        //            if (i%b==0)
        //            {
        //                result = i;
        //            }
        //        }
        //        return result;
        //    }
        //}
        public static int FindNumberOfPositive(int a)
        {
            int result = 0;
            if (a <= 0)
            {
                throw new Exception("a can not be <= 0");
                
            }
            else
            {
                for (int i = 1; i * i < a; i++)
                {
                    result++;
                }
            }
            return result;
        }
        public static int FindLargestDivisor(int a)
        {
            if (a==0)
            {
                throw new Exception("a con not be = 0");
            }
            int result = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    result = i;
                }
            }
            return result;
        }
        public static int DivideSeven(int a, int b)
        {
            int result = 0;
            if (a==0&&b==0)
            {
                throw new Exception("no range");
            }
            if (b < a)
            {
                int t = a;
                a = b;
                b = t;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        public static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                throw new Exception("Num have to be more than zero");
            }
            int tmp1 = 1;
            int tmp2 = 1;
            int result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = tmp1 + tmp2;
                tmp1 = tmp2;
                tmp2 = result;
            }
            return result;
        }
        public static int Euclid(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public static int HalfDivision(int cub)
        {
            int left = 0;
            int right = cub;
            int centr = 0;

            if (cub < 0)
            {
                throw new Exception("cub can not be < 0");
            }

            do
            {
                centr = (left + right) / 2;
                if (Math.Pow(centr, 3) < cub)
                {
                    left = centr;
                }
                else
                {
                    right = centr;
                }
            }
            while (Math.Pow(centr, 3) != cub);
            return centr;
        }
        public static int FindNumbersOdd(int a)
        {
            if (a==0)
            {
                throw new Exception("not range");
            }
            int result = 0;
            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                {
                    result++;
                }
                a /= 10;
            }
            return result;
        }
        public static int Reverse(int a)
        {
            int result = 0;
            while (a != 0)
            {
                result *= 10;
                result += a % 10;
                a /= 10;
            }
            return result;
        }
        public static void Task11(ref int a, ref int b)
        {

        }
        public static string SameNumbers(int a, int b)
        {
            string result = "Нет";
            int d, c;
            while (a > 0)
            {
                d = a % 10;
                a = a / 10;
                c = b;
                while (c > 0)
                {
                    if (c % 10 == d)
                    {
                        result = "Да";
                        break;
                    }
                    c = c / 10;
                }
                if (result == "Да")
                    break;
            }
            return result;
        }
    }
}
