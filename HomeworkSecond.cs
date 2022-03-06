using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class HomeworkSecond
    {
        public static int Task1(int a, int b)
        {
            int c;
            if (a > b)
            {
                c = (a + b);
            }
            else if (a == b)
            {
                c = (a * b);
            }
            else
            {
                c = (a - b);
            }
            return c;
        }
        public static string Task2(int x, int y)
        {
            string result = "";
            if (x > 0 && y > 0)
            {
                result = "Первая четверть";
            }
            else if (x < 0 && y > 0)
            {
                result = "Вторая четверть";
            }
            else if (x < 0 && y < 0)
            {
                result = "Третья четверть";
            }
            else if (x > 0 && y < 0)
            {
                result = "Четвертая четверть";
            }
            else
            {
                result = "Зачем ты вводишь нули?";
            }
            return result;
        }
        public static string Task3(int a, int b, int c)
        {
            string result = "";
            if (a < b && a < c && b < c)
            {
                result = $"{a} + {b} +{c}";
            }
            else if (c < b && b < a && c < b)
            {
                result = $"{c} {b} {a}";
            }
            else if (b < a && a < c && b < c)
            {
                result = $"{b} {a} {c}";
            }
            else if (a < c && c < b && a < b)
            {
                result = $"{a} {c} {b}";
            }
            else if (b < c && c < a && b < a)
            {
                result = $"{b} {c} {a}";
            }
            else
            {
                result = $"{c} {a} {b}";
            }
            return result;
        }
        public static void Task4(ref string result1, ref string result2)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d >= 0)
            {
                result1 = $"первый корень = {((-b) + Math.Sqrt(d)) / (2 * a)}";
                result2 = $"второй корень = {((-b) - Math.Sqrt(d)) / (2 * a)}";
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
        }
        public static string Task5(int num)
        {
            string Minus = "";
            string firstWord = "";
            string secondWord = "";
            string result = "";

            if ((num > -9 && num < 9) || (num < -99 && num > 99))
            {
                throw new Exception("Number is not in raange");
            }
            if (num < 0)
            {
                num *= -1;
                Minus = "Минус ";
            }
            if (num < 20)
            {
                switch (num)
                {
                    case 10: firstWord = "Десять"; break;
                    case 11: firstWord = "Одиннадцать"; break;
                    case 12: firstWord = "Двенадцать"; break;
                    case 13: firstWord = "Тринадцать"; break;
                    case 14: firstWord = "Четырнадцать"; break;
                    case 15: firstWord = "Пятнадцать"; break;
                    case 16: firstWord = "Шестнадцать"; break;
                    case 17: firstWord = "Семьнадцать"; break;
                    case 18: firstWord = "Восемьнадцать"; break;
                    case 19: firstWord = "Девятнадцать"; break;
                }
                result = $"{Minus}{firstWord}";
            }
            else
            {
                switch (num - (num % 10))
                {
                    case 20: firstWord = "Двадцать"; break;
                    case 30: firstWord = "Тридцать"; break;
                    case 40: firstWord = "Сорок"; break;
                    case 50: firstWord = "Пятьдесят"; break;
                    case 60: firstWord = "Шестьдесят"; break;
                    case 70: firstWord = "Семьдесят"; break;
                    case 80: firstWord = "Восемьдесят"; break;
                    case 90: firstWord = "Девяносто"; break;
                }
                switch (num % 10)
                {
                    case 0: secondWord = ""; break;
                    case 1: secondWord = "один"; break;
                    case 2: secondWord = "два"; break;
                    case 3: secondWord = "три"; break;
                    case 4: secondWord = "четыре"; break;
                    case 5: secondWord = "пять"; break;
                    case 6: secondWord = "шесть"; break;
                    case 7: secondWord = "семь"; break;
                    case 8: secondWord = "восемь"; break;
                    case 9: secondWord = "девять"; break;
                }
                result = $"{Minus}{firstWord} {secondWord}";

            }
            return result;
        }
    }
}
