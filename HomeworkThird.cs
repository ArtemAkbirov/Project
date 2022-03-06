using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class HomeworkThird
    {
        public static int Task1(int a, int b)
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
        //public static void Task2(ref int result)
        //{
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    for (int i = a; i < 1000; i += a)
        //    {
        //        result = i;
        //    }
           
        //}
        public static int Task3(int a)
        {
            int result = 0;
            if (a < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число!!");
                
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
        public static int Task4(int a)
        {
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
        public static int Task5(int a, int b)
        {
            int result = 0;
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
        public static int Task6(int n)
        {
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
        public static int Task7(int a, int b)
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
        public static int Task8(int cub)
        {
            int left = 0;
            int right = cub;
            int centr = 0;

            if (cub < 0)
            {
                Console.WriteLine("Было введено отрицатеельное число");
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
        public static int Task9(int a)
        {
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
        public static int Task10(int a)
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
        public static string Task12(int a, int b)
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
